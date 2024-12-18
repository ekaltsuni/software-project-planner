﻿using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;

namespace SoftwarePlanner
{
    public partial class LoginForm : Form
    {
        public string role;

        public LoginForm()
        {
            InitializeComponent();
            UserSearch.isSearchedUser = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (!usernameBox.Text.Equals("") && !passwordBox.Text.Equals(""))
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(RETURN_USER, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User.id = reader.GetInt32(reader.GetOrdinal("id"));
                            getRole();
                            login();
                        }
                        else
                        {
                            MessageBox.Show("Λανθασμένο όνομα χρήστη ή κωδικός.");
                            return;
                        }
                    }
                }
                this.Hide();
                UserProfileForm userProfile = new UserProfileForm();
                userProfile.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Παρακαλώ συμπληρώστε όνομα & κωδικό.");
        }

        private void login()
        {
            if (User.role.Equals("Developer"))
            {
                Role.isAdmin = false;
                Role.isDeveloper = true;
                Role.isClient = false;
                Role.isVisitor = false;

            }
            else if (User.role.Equals("Πελάτης"))
            {
                Role.isAdmin = false;
                Role.isDeveloper = false;
                Role.isClient = true;
                Role.isVisitor = false;
            }
            else if (User.role.Equals("Admin"))
            {
                Role.isAdmin = true;
                Role.isDeveloper = false;
                Role.isClient = false;
                Role.isVisitor = false;
            }
            else
            {
                Role.isAdmin = false;
                Role.isVisitor = true;
                Role.isDeveloper = false;
                Role.isClient = false;
            }
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfileForm userProfile = new UserProfileForm();
            userProfile.ShowDialog();
            this.Close();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            UserSearch.isSearchedUser = false;
            Role.isVisitor = true;
            Role.isClient = false;
            Role.isDeveloper = false;
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) Application.Exit();
        }
    }
}
