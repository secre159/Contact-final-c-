using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using tictactoe;

namespace WindowsFormsApp2
{
    public partial class eContact : Form
    {
        private MySqlConnection connection;

        public eContact()
        {
            ControlBox = false;
            InitializeComponent();
            //MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ConnectDB();
            dataGridViewDisplay.SelectionChanged += dataGridViewDisplay_SelectionChanged;

            txtbox_Fname.KeyPress += txtbox_Fname_KeyPress;
        }

        private void ConnectDB()
        {
            string connString = "server=localhost;user=root;password=12345678;port=3308;database=finals_db;";
            connection = new MySqlConnection(connString);

            try
            {
                connection.Open();
                //MessageBox.Show("Connected to the database Successfully!");
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }

        private void dataGridViewDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDisplay.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDisplay.SelectedRows[0];
                txtbox_ContactId1.Text = selectedRow.Cells["contact_id"].Value?.ToString();
                txtbox_Fname.Text = selectedRow.Cells["first_name"].Value?.ToString();
                txtbox_Lname.Text = selectedRow.Cells["last_name"].Value?.ToString();
                txtbox_ContactNo.Text = selectedRow.Cells["contact_no"].Value?.ToString();
                txtbox_Address.Text = selectedRow.Cells["address"].Value?.ToString();
                cmb_Gender.SelectedItem = selectedRow.Cells["gender"].Value?.ToString();
            }
        }

        private void InsertContact(string firstName, string lastName, string contactNo, string address, string gender)
        {
            if (IsContactExists(firstName, lastName, contactNo))
            {
                MessageBox.Show($"A contact with the name '{firstName} {lastName}' and contact number '{contactNo}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Contacts (first_name, last_name, contact_no, address, gender) " +
                           "VALUES (@firstName, @lastName, @contactNo, @address, @gender)";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@contactNo", contactNo);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Contact '{firstName} {lastName}' with contact number '{contactNo}' was added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding contact: " + ex.Message);
            }
        }

        private bool IsContactExists(string firstName, string lastName, string contactNo)
        {
            string query = "SELECT COUNT(*) FROM Contacts WHERE first_name = @firstName AND last_name = @lastName AND contact_no = @contactNo";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@contactNo", contactNo);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }


        private void UpdateContact(int contactId, string firstName, string lastName, string contactNo, string address, string gender)
        {
            string query = "UPDATE Contacts " +
                           "SET first_name = @firstName, last_name = @lastName, contact_no = @contactNo, address = @address, gender = @gender " +
                           "WHERE contact_id = @contactId";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@contactNo", contactNo);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@contactId", contactId);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"[ {firstName} {lastName} ] was updated successfully!");
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating contact: " + ex.Message);
            }

        }

        private void DeleteContact(int contactId)
        {
            string queryGetName = "SELECT first_name, last_name FROM Contacts WHERE contact_id = @contactId";
            string contactName = "";

            MySqlCommand cmdGetName = new MySqlCommand(queryGetName, connection);
            cmdGetName.Parameters.AddWithValue("@contactId", contactId);

            try
            {
                using (MySqlDataReader reader = cmdGetName.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contactName = $"{reader["first_name"]} {reader["last_name"]}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving contact name: " + ex.Message);
                return;
            }

            string queryDelete = "DELETE FROM Contacts WHERE contact_id = @contactId";
            MySqlCommand cmdDelete = new MySqlCommand(queryDelete, connection);
            cmdDelete.Parameters.AddWithValue("@contactId", contactId);

            try
            {
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show($"Contact [ {contactName} ] was deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting contact: " + ex.Message);
            }
        }


        private void LoadContacts()
        {
            string query = "SELECT * FROM Contacts";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridViewDisplay.Font = new Font("Arial", 10);
                dataGridViewDisplay.DataSource = dt;

                dataGridViewDisplay.Columns["contact_id"].HeaderText = "Contact ID";
                dataGridViewDisplay.Columns["contact_id"].HeaderCell.Style.Font = new Font(dataGridViewDisplay.Font, FontStyle.Bold);

                dataGridViewDisplay.Columns["first_name"].HeaderText = "First Name";
                dataGridViewDisplay.Columns["first_name"].HeaderCell.Style.Font = new Font(dataGridViewDisplay.Font, FontStyle.Bold);

                dataGridViewDisplay.Columns["last_name"].HeaderText = "Last Name";
                dataGridViewDisplay.Columns["last_name"].HeaderCell.Style.Font = new Font(dataGridViewDisplay.Font, FontStyle.Bold);

                dataGridViewDisplay.Columns["contact_no"].HeaderText = "Contact Number";
                dataGridViewDisplay.Columns["contact_no"].HeaderCell.Style.Font = new Font(dataGridViewDisplay.Font, FontStyle.Bold);

                dataGridViewDisplay.Columns["address"].HeaderText = "Address";
                dataGridViewDisplay.Columns["address"].HeaderCell.Style.Font = new Font(dataGridViewDisplay.Font, FontStyle.Bold);

                dataGridViewDisplay.Columns["gender"].HeaderText = "Gender";
                dataGridViewDisplay.Columns["gender"].HeaderCell.Style.Font = new Font(dataGridViewDisplay.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading contacts: " + ex.Message);
            }
        }

        public void clear()
        {
            try
            {
                txtbox_ContactId1.Clear();
                txtbox_Fname.Clear();
                txtbox_Lname.Clear();
                txtbox_ContactNo.Clear();
                txtbox_Address.Clear();
                cmb_Gender.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Clearing Input Data: " + ex.Message);
            }
        }
        private void btn_Add_Click(object sender ,EventArgs e)
        {
            {
                    if (dataGridViewDisplay.DataSource == null)
                    {
                        MessageBox.Show("No data loaded. Please load data before adding a contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (cmb_Gender.SelectedItem == null)
                    {
                        MessageBox.Show("Please input data first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        InsertContact(txtbox_Fname.Text, txtbox_Lname.Text, txtbox_ContactNo.Text, txtbox_Address.Text, cmb_Gender.SelectedItem.ToString());
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Error adding contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisplay.DataSource == null)
            {
                MessageBox.Show("No data loaded. Please load data before updating a contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            { 
                UpdateContact(Convert.ToInt32(txtbox_ContactId1.Text), txtbox_Fname.Text, txtbox_Lname.Text, txtbox_ContactNo.Text, txtbox_Address.Text, cmb_Gender.SelectedItem.ToString());
            }
            catch (FormatException ex)
            {
               MessageBox.Show("Error updating contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDisplay.DataSource == null)
            {
                MessageBox.Show("No data loaded. Please load data before deleting a contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteContact(Convert.ToInt32(txtbox_ContactId1.Text));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error deleting contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading contacts: " + ex.Message);
            }
        }

        private void txtbox_Search_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtbox_Search.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                string query = "SELECT * FROM Contacts WHERE first_name LIKE @searchTerm OR last_name LIKE @searchTerm OR contact_no LIKE @searchTerm OR address LIKE @searchTerm OR gender LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                try
                {
                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridViewDisplay.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching contacts: " + ex.Message);
                }
            }
            else
            {
                LoadContacts();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowsForm2 form2 = new WindowsForm2();
            form2.Show();
        }

        private void txtbox_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtbox_Lname.Focus();
            }
        }

        private void txtbox_Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtbox_ContactNo.Focus();
            }
        }

        private void txtbox_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmb_Gender.Focus();
            }
        }

        private void txtbox_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_Add_Click(sender, e);
            }
        }

    }
}