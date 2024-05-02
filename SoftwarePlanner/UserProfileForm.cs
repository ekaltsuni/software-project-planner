﻿using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static SoftwarePlanner.SQLConstants;

namespace SoftwarePlanner
{
    public partial class UserProfileForm : Form
    {
        string email, username, password, role, name, surname, gender, skills, cv, portfolio, date_of_birth,
                link, description, other, portfolio_title, portfolio_link;
        string selectedImagePath = "";
        DateTime dateOfBirth;
        int[] skillArray = new int[8];
  
        public UserProfileForm()
        {
            InitializeComponent();
            initialState();

        }

        // Show data if user exists in the db
        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            if (Role.isClient)
            {
                fillMajorFields();
                fillClientFields();
                
            }
            else if (Role.isDeveloper)
            {
                fillMajorFields();
                fillDeveloperFields();
            }
        }

        private void fillMajorFields()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_USER_VARIABLES, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", User.id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader.GetString(reader.GetOrdinal("email"));
                        username = reader.GetString(reader.GetOrdinal("username"));
                        password = reader.GetString(reader.GetOrdinal("password"));

                        if (!reader.IsDBNull(reader.GetOrdinal("name"))) 
                        {
                            name = reader.GetString(reader.GetOrdinal("name"));
                            nameBox.Text = name;

                        }
                        else
                        {
                            nameBox.Text = "";
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("surname")))
                        {
                            surname = reader.GetString(reader.GetOrdinal("surname"));
                            surnameBox.Text = surname;
                        }
                        else
                        {
                            surnameBox.Text = "";
                        }

                        if (reader["image_data"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["image_data"];
                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    profileImagePictureBox.Image = Image.FromStream(ms);
                                    profileImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                            else
                            {
                                profileImagePictureBox.Image = SoftwarePlanner.Properties.Resources.upload_icon;
                                profileImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        usernameBox.Text = username;
                        emailBox.Text = email;
                        passwordBox.Text = password;
                    }

                }
            }
        }

        private void fillClientFields()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_CLIENT_VARIABLES, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", User.id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("date_of_birth")))
                        {
                            date_of_birth = reader.GetString(reader.GetOrdinal("date_of_birth"));
                            datePicker.Value = DateTime.Parse(date_of_birth);
                        }
                        else
                        {
                            datePicker.Value = DateTime.Today;
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("link")))
                        {
                            link = reader.GetString(reader.GetOrdinal("link"));
                            linkBox.Text = link;
                        }
                        else
                        {
                            linkBox.Text = "";

                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("description")))
                        {
                            description = reader.GetString(reader.GetOrdinal("description"));
                            descriptionBox.Text = description;
                        }
                        else
                        {
                            descriptionBox.Text = "";
                        }
                    }
                }
            }
        }

        private void fillDeveloperFields()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand skillsCommand = new SQLiteCommand(RETURN_SKILLS, connection))
            //using (SQLiteCommand cvCommand = new SQLiteCommand(AppConstants.RETURN_CV, connection))
            using (SQLiteCommand portfolioCommand = new SQLiteCommand(RETURN_PORTFOLIO_VARIABLES, connection))
            {
                connection.Open();
                skillsCommand.Parameters.AddWithValue("@id", User.id);
                //cvCommand.Parameters.AddWithValue("@id", User.id);
                portfolioCommand.Parameters.AddWithValue("@id", User.id);
                using (SQLiteDataReader reader = skillsCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        for (int i = 0; i < skillArray.Length; i++) skillArray[i] = reader.GetInt32(i + 1);
                        int otherColumnIndex = reader.GetOrdinal("other");
                        if (!reader.IsDBNull(otherColumnIndex)) other = reader.GetString(otherColumnIndex);
                        else other = "";
                    }
                    for (int i = 0; i < skillArray.Length; i++) skillsListBox.SetItemChecked(i, skillArray[i] == 1);
                    skillsBox.Text = other;
                }
                /*using (SQLiteDataReader reader = cvCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //cv
                    }
                } */
                using (SQLiteDataReader reader = portfolioCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        portfolio_title = reader.IsDBNull(reader.GetOrdinal("portfolio_title")) ? "" : reader.GetString(reader.GetOrdinal("portfolio_title"));
                        portfolio_link = reader.IsDBNull(reader.GetOrdinal("portfolio_link")) ? "" : reader.GetString(reader.GetOrdinal("portfolio_link"));
                        dataGridView.Rows.Add(portfolio_title, portfolio_link);
                    }

                }

            }
        }


        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role.isVisitor = true;
            Role.isClient = false;
            Role.isDeveloper = false;
            this.Hide();
            HomeForm home = new HomeForm();
            home.ShowDialog();
            this.Close();
        }

        private void UserProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Update fields if user exists or create user if visitor
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Role.isDeveloper) updateDeveloper();
            else if (Role.isClient) updateClient();
            else
            {
                if (!string.IsNullOrEmpty(usernameBox.Text) &&
                    !string.IsNullOrEmpty(passwordBox.Text) &&
                    !string.IsNullOrEmpty(emailBox.Text) &&
                    roleComboBox.SelectedIndex == 0)
                {
                    createClient();   
                }
                else if (!string.IsNullOrEmpty(usernameBox.Text) &&
                    !string.IsNullOrEmpty(passwordBox.Text) &&
                    !string.IsNullOrEmpty(emailBox.Text) &&
                    roleComboBox.SelectedIndex == 1)
                {
                    createDeveloper();
                }
                else MessageBox.Show("Παρακαλώ συμπληρώστε τα υποχρεωτικά πεδία.");
            }
            updateProfileImage();
        }

        private void updateDeveloper()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                using (SQLiteCommand command = new SQLiteCommand(UPDATE_USER_VARIABLES, connection))
                using (SQLiteCommand skillsCommand = new SQLiteCommand(UPDATE_SKILLS, connection))
                using (SQLiteCommand portfolioUpdateEntryCommand = new SQLiteCommand(UPDATE_PORTFOLIO_ENTRY, connection))


                {
                    connection.Open();
                    // Update user related fields
                    command.Parameters.AddWithValue("@id", User.id);
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.ExecuteNonQuery();
                    // Update skill related fields
                    skillsCommand.Parameters.AddWithValue("@id", User.id);
                    skillsCommand.Parameters.AddWithValue("@c", returnFlag(0));
                    skillsCommand.Parameters.AddWithValue("@css", returnFlag(1));
                    skillsCommand.Parameters.AddWithValue("@html", returnFlag(2));
                    skillsCommand.Parameters.AddWithValue("@java", returnFlag(3));
                    skillsCommand.Parameters.AddWithValue("@javascript", returnFlag(4));
                    skillsCommand.Parameters.AddWithValue("@php", returnFlag(5));
                    skillsCommand.Parameters.AddWithValue("@python", returnFlag(6));
                    skillsCommand.Parameters.AddWithValue("@ruby", returnFlag(7));
                    skillsCommand.Parameters.AddWithValue("@other", skillsBox.Text);
                    skillsCommand.ExecuteNonQuery();
                    // Update portfolio related fields
                    readPortfolio();
                    portfolioUpdateEntryCommand.Parameters.AddWithValue("@id", User.id);
                    portfolioUpdateEntryCommand.Parameters.AddWithValue("@portfolio_title", portfolio_title);
                    portfolioUpdateEntryCommand.Parameters.AddWithValue("@portfolio_link", portfolio_link);
                    portfolioUpdateEntryCommand.ExecuteNonQuery();

                    MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");
                }
            }
        }

        private void createDeveloper()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                using (SQLiteCommand command = new SQLiteCommand(CREATE_USER_VARIABLES, connection))
                using (SQLiteCommand userIDcommand = new SQLiteCommand(RETURN_LATEST_USER_ID, connection))
                using (SQLiteCommand skillsCommand = new SQLiteCommand(CREATE_SKILLS, connection))
                using (SQLiteCommand portfolioCommand = new SQLiteCommand(CREATE_PORTFOLIO_VARIABLES, connection))

                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@role", roleComboBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@signing_date", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = userIDcommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Update skill related fields
                            skillsCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                            skillsCommand.Parameters.AddWithValue("@other", skillsBox.Text);
                            skillsCommand.Parameters.AddWithValue("@c", returnFlag(0));
                            skillsCommand.Parameters.AddWithValue("@css", returnFlag(1));
                            skillsCommand.Parameters.AddWithValue("@html", returnFlag(2));
                            skillsCommand.Parameters.AddWithValue("@java", returnFlag(3));
                            skillsCommand.Parameters.AddWithValue("@javascript", returnFlag(4));
                            skillsCommand.Parameters.AddWithValue("@php", returnFlag(5));
                            skillsCommand.Parameters.AddWithValue("@python", returnFlag(6));
                            skillsCommand.Parameters.AddWithValue("@ruby", returnFlag(7));
                            skillsCommand.ExecuteNonQuery();

                            readPortfolio();
                            portfolioCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                            portfolioCommand.Parameters.AddWithValue("@portfolio_title", portfolio_title);
                            portfolioCommand.Parameters.AddWithValue("@portfolio_link", portfolio_link);
                            portfolioCommand.ExecuteNonQuery();

                            MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");
                        }
                    }
                }
            }
        }

        private void updateClient()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                using (SQLiteCommand command = new SQLiteCommand(UPDATE_USER_VARIABLES, connection))
                using (SQLiteCommand clientOnlyCommand = new SQLiteCommand(UPDATE_CLIENT_VARIABLES, connection))
                {
                    connection.Open();
                    // Update user related fields
                    command.Parameters.AddWithValue("@id", User.id);
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.ExecuteNonQuery();
                    // Update client related fields
                    clientOnlyCommand.Parameters.AddWithValue("@id", User.id);
                    clientOnlyCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                    clientOnlyCommand.Parameters.AddWithValue("@link", linkBox.Text);
                    clientOnlyCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                    clientOnlyCommand.ExecuteNonQuery();

                    MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");
                }
            }
        }

        private void createClient()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                using (SQLiteCommand command = new SQLiteCommand(CREATE_USER_VARIABLES, connection))
                using (SQLiteCommand userIDcommand = new SQLiteCommand(RETURN_LATEST_USER_ID, connection))
                using (SQLiteCommand clientCommand = new SQLiteCommand(CREATE_CLIENT_VARIABLES, connection))

                {
                    connection.Open();
                    // Update user related fields
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@role", roleComboBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@signing_date", DateTime.Now.ToString("yyyy-MM-dd"));
                    using (SQLiteDataReader reader = userIDcommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Update client related fields
                            clientCommand.Parameters.AddWithValue("@id", reader.GetInt32(0));
                            clientCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                            clientCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                            clientCommand.Parameters.AddWithValue("@link", linkBox.Text);                         
                            command.ExecuteNonQuery();
                            clientCommand.ExecuteNonQuery();
                            MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");                                                      
                        }
                    }
                }
            }
        }

        private int returnFlag (int index) 
        {
             return skillsListBox.GetItemChecked(index) ? 1 : 0;   
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex == 0)
            {
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox18.Visible = true;
                datePicker.Visible = true;
                descriptionBox.Visible = true;
                linkBox.Visible = true;
                dataGridView.Visible = false;
                textBox17.Visible = true;
                clientVisibilityFields.Visible = true;
                developerVisibilityFields.Visible = false;
                skillsBox.Visible = false;
                skillsListBox.Visible = false;

            }
            else if (roleComboBox.SelectedIndex == 1)
            {
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox18.Visible = false;
                datePicker.Visible = false;
                descriptionBox.Visible = false;
                linkBox.Visible = false;
                dataGridView.Visible = true;
                textBox17.Visible = true;
                clientVisibilityFields.Visible = false;
                developerVisibilityFields.Visible = true;
                skillsBox.Visible = true;
                skillsListBox.Visible = true;
            }
        }

        private void setVibilityFields ()
        {
            // to-do
        }

        private void αρχικήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void profileImagePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                profileImagePictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void updateProfileImage()
        {
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                byte[] imageData;
                using (Image image = Image.FromFile(selectedImagePath))
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }

                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "UPDATE User SET image_data = @image_data WHERE id = @userId";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@image_data", imageData);
                        cmd.Parameters.AddWithValue("@userId", User.id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    
        private void readPortfolio()
        {

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                portfolio_title = row.Cells[0].Value?.ToString();
                portfolio_link = row.Cells[1].Value?.ToString();

                if (string.IsNullOrWhiteSpace(portfolio_title) || string.IsNullOrWhiteSpace(portfolio_link))
                {
                    continue;
                }

            }
        }

        private void initialState()
        {
            getRole();
            if (Role.isDeveloper == true)
            {
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox18.Visible = false;
                developerVisibilityFields.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Developer";
                αποσύνδεσηToolStripMenuItem.Visible = true;
                datePicker.Visible = false;
                descriptionBox.Visible = false;
                linkBox.Visible = false;
                dataGridView.Visible = true;
                skillsBox.Visible = true;
                skillsListBox.Visible = true;
            }
            else if (Role.isClient == true)
            {
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox18.Visible = true;
                clientVisibilityFields.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Πελάτης";
                αποσύνδεσηToolStripMenuItem.Visible = true;
                datePicker.Visible = true;
                descriptionBox.Visible = true;
                linkBox.Visible = true;
                dataGridView.Visible = false;
                skillsBox.Visible= false;
                skillsListBox.Visible = false;
            }
            else
            {
                roleComboBox.Enabled = true;
                αποσύνδεσηToolStripMenuItem.Visible = false;
                newsFeedTextBox.Visible = false;
                newsFeedRichTextBox.Visible = false;
                projectsTextBox.Visible = false;
                projectsRichTextBox.Visible = false;
                ratingsTextBox.Visible = false;
                ratingsRichTextBox.Visible = false;
                textBox17.Visible = false;
            }
        }
    }
}
