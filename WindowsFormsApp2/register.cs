using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class register : Form
    {
        private MySqlConnection connection;

        public register()
        {
            InitializeComponent();;
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            txtbox_Email.KeyPress += txtbox_Email_KeyPress;
            txtbox_Username.KeyPress += txtbox_Username_KeyPress;
            txtbox_Password.KeyPress += txtbox_Password_KeyPress;
            txtbox_Cpassword.KeyPress += txtbox_Cpassword_KeyPress;

            InitializeConnection();
        }

        private void InitializeConnection()
        {
            string connString = "server=localhost;user=root;password=12345678;port=3308;database=finals_db;";
            connection = new MySqlConnection(connString);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btn_Register_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
                return;
            }

            string email = txtbox_Email.Text;
            string username = txtbox_Username.Text;
            string password = txtbox_Password.Text;
            string confirmPassword = txtbox_Cpassword.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format it should be like [ yourname@doamin");
                txtbox_Email.Clear();
                txtbox_Email.Focus();
                connection.Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_Password.Clear();
                txtbox_Cpassword.Clear();
                txtbox_Password.Focus();
                connection.Close();
                return;
            }

            string query = "INSERT INTO users (email, username, password) VALUES (@email, @username, @password)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtbox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtbox_Username.Focus();
            }
        }

        private void txtbox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtbox_Password.Focus();
            }
        }

        private void txtbox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtbox_Cpassword.Focus();
            }
        }

        private void txtbox_Cpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Register_Click_1(sender, e);
            }
        }

    }
}