using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwarePlanner
{
    public partial class UserProfileForm : Form
    {
        String email, username, password, role, name, surname, gender, skills, cv, portfolio, date_of_birth,
                link, description;
        DateTime dateOfBirth;
        public UserProfileForm()
        {
            InitializeComponent();
            initialState();

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            if (Role.isDeveloper || Role.isClient)
            {
                using (SQLiteConnection connection = new SQLiteConnection(AppConstants.CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(AppConstants.RETURN_USER_VARIABLES, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", User.id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader.GetString(reader.GetOrdinal("email"));
                            username = reader.GetString(reader.GetOrdinal("username"));
                            name = reader.GetString(reader.GetOrdinal("name"));
                            surname = reader.GetString(reader.GetOrdinal("surname"));
                            password = reader.GetString(reader.GetOrdinal("password"));

                        }

                        usernameBox.Text = username;
                        emailBox.Text = email;
                        nameBox.Text = name;
                        surnameBox.Text = surname;
                        passwordBox.Text = password;

                        //command.Dispose();
                        //connection.Close();
                    }

                }
            }
            if (Role.isClient)
            {
                using (SQLiteConnection connection = new SQLiteConnection(AppConstants.CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(AppConstants.RETURN_CLIENT_VARIABLES, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", User.id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            date_of_birth = reader.GetString(reader.GetOrdinal("date_of_birth"));
                            link = reader.GetString(reader.GetOrdinal("link"));
                            description = reader.GetString(reader.GetOrdinal("description"));

                        }

                        datePicker.Value = DateTime.Parse(date_of_birth);
                        linkBox.Text = link;
                        descriptionBox.Text = description;
                    }
                }
            }
            if (Role.isDeveloper)
            {
                using (SQLiteConnection connection = new SQLiteConnection(AppConstants.CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(AppConstants.RETURN_DEVELOPER_VARIABLES, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", User.id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            skills = reader.GetString(reader.GetOrdinal("skills"));
                            portfolio = reader.GetString(reader.GetOrdinal("portfolio_links"));

                        }
                        //skillsBox.Text = skills;
                        portfolioBox.Text = portfolio;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(AppConstants.CONNECTION_STRING))

                if (Role.isDeveloper)
                {

                    using (SQLiteCommand command = new SQLiteCommand(AppConstants.UPDATE_USER_VARIABLES, connection))
                    using (SQLiteCommand developerOnlyCommand = new SQLiteCommand(AppConstants.UPDATE_DEVELOPER_VARIABLES, connection))

                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@username", usernameBox.Text);
                        command.Parameters.AddWithValue("@password", passwordBox.Text);
                        command.Parameters.AddWithValue("@email", emailBox.Text);
                        command.Parameters.AddWithValue("@name", nameBox.Text);
                        command.Parameters.AddWithValue("@surname", surnameBox.Text);
                        command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                        //developerOnlyCommand.Parameters.AddWithValue("@skills", .Text);
                        //developerOnlyCommand.Parameters.AddWithValue("@cv", genderComboBox.Text);
                        developerOnlyCommand.Parameters.AddWithValue("@portfolio_links", portfolioBox.Text);


                        command.Parameters.AddWithValue("@id", User.id);
                        developerOnlyCommand.Parameters.AddWithValue("@id", User.id);

                        command.ExecuteNonQuery();
                        developerOnlyCommand.ExecuteNonQuery();
                        MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");

                    }
                }

                else if (Role.isClient)
                {

                    using (SQLiteCommand command = new SQLiteCommand(AppConstants.UPDATE_USER_VARIABLES, connection))
                    using (SQLiteCommand clientOnlyCommand = new SQLiteCommand(AppConstants.UPDATE_CLIENT_VARIABLES, connection))


                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@username", usernameBox.Text);
                        command.Parameters.AddWithValue("@password", passwordBox.Text);
                        command.Parameters.AddWithValue("@email", emailBox.Text);
                        command.Parameters.AddWithValue("@name", nameBox.Text);
                        command.Parameters.AddWithValue("@surname", surnameBox.Text);
                        command.Parameters.AddWithValue("@gender", genderComboBox.Text);

                        command.Parameters.AddWithValue("@id", User.id);


                        clientOnlyCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                        clientOnlyCommand.Parameters.AddWithValue("@link", linkBox.Text);
                        clientOnlyCommand.Parameters.AddWithValue("@description", descriptionBox.Text);

                        clientOnlyCommand.Parameters.AddWithValue("@id", User.id);

                        command.ExecuteNonQuery();
                        clientOnlyCommand.ExecuteNonQuery();

                        MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");

                    }
                }
                else 
                {
                    if (!string.IsNullOrEmpty(usernameBox.Text) &&
                       !string.IsNullOrEmpty(passwordBox.Text) &&
                       !string.IsNullOrEmpty(emailBox.Text) &&
                       roleComboBox.SelectedItem != null)
                    {
                        using (SQLiteCommand command = new SQLiteCommand(AppConstants.CREATE_USER_VARIABLES, connection))
                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@username", usernameBox.Text);
                            command.Parameters.AddWithValue("@password", passwordBox.Text);
                            command.Parameters.AddWithValue("@email", emailBox.Text);
                            command.Parameters.AddWithValue("@role", roleComboBox.Text);
                            command.Parameters.AddWithValue("@name", nameBox.Text);
                            command.Parameters.AddWithValue("@surname", surnameBox.Text);
                            command.Parameters.AddWithValue("@gender", genderComboBox.Text);

                            command.Parameters.AddWithValue("@id", User.id);
                            if (roleComboBox.SelectedIndex == 0)
                            {
                                using (SQLiteCommand clientCommand = new SQLiteCommand(AppConstants.CREATE_CLIENT_VARIABLES, connection))
                                {
                                    clientCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                                    clientCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                                    clientCommand.Parameters.AddWithValue("@link", linkBox.Text);
                                    clientCommand.Parameters.AddWithValue("@id", User.id);
                                    try
                                    {
                                        command.ExecuteNonQuery();
                                        clientCommand.ExecuteNonQuery();
                                        MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Σφάλμα κατά την αποθήκευση: " + ex.Message);

                                    }
                                }
                            }
                            else if (roleComboBox.SelectedIndex == 1)
                            {
                                using (SQLiteCommand developerCommand = new SQLiteCommand(AppConstants.CREATE_DEVELOPER_VARIABLES, connection))
                                {
                                    //to-do
                                    //developerCommand.Parameters.AddWithValue("@",);
                                    //developerCommand.Parameters.AddWithValue("@skills",);
                                    developerCommand.Parameters.AddWithValue("@portfolio_links", portfolioBox.Text);
                                    developerCommand.Parameters.AddWithValue("@id", User.id);
                                    try
                                    {
                                        command.ExecuteNonQuery();
                                        developerCommand.ExecuteNonQuery();
                                        MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Σφάλμα κατά την αποθήκευση: " + ex.Message);
                                    }

                                }
                            }



                        }

                    }
                    else
                    {
                        MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα υποχρεωτικά πεδία.");

                    }

                }
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
                portfolioBox.Visible = false;
                textBox17.Visible = true;
                clientVisibilityFields.Visible = true;
                developerVisibilityFields.Visible = false;
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
                portfolioBox.Visible = true;
                textBox17.Visible = true;
                clientVisibilityFields.Visible = false;
                developerVisibilityFields.Visible = true;
            }
        }

        private void setVibilityFields ()
        {
            // to-do
        }

        private void updateProfile()
        {

        }

        private void createProfile()
        {

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
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                profileImagePictureBox.Image = new Bitmap(open.FileName);
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
                portfolioBox.Visible = true;
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
                portfolioBox.Visible = false;
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
