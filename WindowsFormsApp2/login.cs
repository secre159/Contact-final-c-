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
    public partial class login : Form
    {
        private MySqlConnection connection;
        private eContact econtactForm;

        public login()
        {
            InitializeComponent();
            ConnectDB();
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            txtbox_Username.KeyPress += txtbox_Username_KeyPress;
            txtbox_Password.KeyPress += txtbox_Password_KeyPress;
        }

        private void ConnectDB()
        {
            string connString = "server=localhost;user=root;password=12345678;port=3308;database=finals_db;";
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new MySqlConnection(connString);
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtbox_Username.Text;
            string enteredPassword = txtbox_Password.Text;

            string query = "SELECT password FROM users WHERE username = @username";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", enteredUsername);

                try
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result.ToString() == enteredPassword)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        econtactForm = new eContact();
                        econtactForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbox_Password.Clear();
                        txtbox_Username.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                btn_Login_Click(sender, e);
            }
        }

        private void lbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registrationForm = new register();
            registrationForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
