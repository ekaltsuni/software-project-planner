using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
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
                link, description, other;
        DateTime dateOfBirth;
        int c, css, html, java, javascript, php, python, ruby, skillFlag;
  

        public UserProfileForm()
        {
            InitializeComponent();
            initialState();

        }

        // Show data if user exists in the db
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
                using (SQLiteCommand skillsCommand = new SQLiteCommand(AppConstants.RETURN_SKILLS, connection))
                //using (SQLiteCommand cvCommand = new SQLiteCommand(AppConstants.RETURN_CV, connection))
                //using (SQLiteCommand portfolioCommand = new SQLiteCommand(AppConstants.RETURN_PORTFOLIO, connection))

                {
                    connection.Open();
                    skillsCommand.Parameters.AddWithValue("@id", User.id);
                    //cvCommand.Parameters.AddWithValue("@id", User.id);
                    //portfolioCommand.Parameters.AddWithValue("@id", User.id);
                    using (SQLiteDataReader reader = skillsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            c = reader.GetInt32(1);
                            css = reader.GetInt32(2);
                            html = reader.GetInt32(3);
                            java = reader.GetInt32(4);
                            javascript = reader.GetInt32(5);
                            php = reader.GetInt32(6);
                            python = reader.GetInt32(7);
                            ruby = reader.GetInt32(8);

                            int otherColumnIndex = reader.GetOrdinal("other");
                            if (!reader.IsDBNull(otherColumnIndex))
                            {
                                other = reader.GetString(otherColumnIndex);
                            }
                            else
                            {
                                other = "";
                            }
                        }
                        getFlag(c, 0);
                        getFlag(css, 1);
                        getFlag(html, 2);
                        getFlag(java, 3);
                        getFlag(javascript, 4);
                        getFlag(php, 5);
                        getFlag(python, 6);
                        getFlag(ruby, 7);
                        skillsBox.Text = other;
                    }
                    /*using (SQLiteDataReader reader = cvCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //cv
                        }
                    }
                    using (SQLiteDataReader reader = portfolioCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            portfolio = reader.GetString(reader.GetOrdinal("portfolio_links"));

                        }
                        portfolioBox.Text = portfolio;

                    }*/

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

        // Update fields if user exists or create user if visitor
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(AppConstants.CONNECTION_STRING))

                if (Role.isDeveloper)
                {

                    using (SQLiteCommand command = new SQLiteCommand(AppConstants.UPDATE_USER_VARIABLES, connection))
                    using (SQLiteCommand skillsCommand = new SQLiteCommand(AppConstants.UPDATE_SKILLS, connection))

                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@username", usernameBox.Text);
                        command.Parameters.AddWithValue("@password", passwordBox.Text);
                        command.Parameters.AddWithValue("@email", emailBox.Text);
                        command.Parameters.AddWithValue("@name", nameBox.Text);
                        command.Parameters.AddWithValue("@surname", surnameBox.Text);
                        command.Parameters.AddWithValue("@gender", genderComboBox.Text);

                        if (returnFlag(0) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@c", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@c", 0);


                        }
                        if (returnFlag(1) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@css", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@css", 0);


                        }
                        if (returnFlag(2) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@html", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@html", 0);


                        }
                        if (returnFlag(3) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@java", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@java", 0);


                        }
                        if (returnFlag(4) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@javascript", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@javascript", 0);


                        }
                        if (returnFlag(5) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@php", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@php", 0);


                        }
                        if (returnFlag(6) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@python", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@python", 0);


                        }
                        if (returnFlag(7) == 1)
                        {
                            skillsCommand.Parameters.AddWithValue("@ruby", 1);

                        }
                        else
                        {
                            skillsCommand.Parameters.AddWithValue("@ruby", 0);


                        }
                        skillsCommand.Parameters.AddWithValue("@other", skillsBox.Text);
                        command.Parameters.AddWithValue("@id", User.id);
                        skillsCommand.Parameters.AddWithValue("@id", User.id);
                        command.ExecuteNonQuery();
                        skillsCommand.ExecuteNonQuery();
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
                       roleComboBox.SelectedIndex == 0)
                    {
                        using (SQLiteCommand command = new SQLiteCommand(AppConstants.CREATE_USER_VARIABLES, connection))
                        using (SQLiteCommand clientCommand = new SQLiteCommand(AppConstants.CREATE_CLIENT_VARIABLES, connection))

                        {
                            connection.Open();

                            command.Parameters.AddWithValue("@username", usernameBox.Text);
                            command.Parameters.AddWithValue("@password", passwordBox.Text);
                            command.Parameters.AddWithValue("@email", emailBox.Text);
                            command.Parameters.AddWithValue("@role", roleComboBox.Text);
                            command.Parameters.AddWithValue("@name", nameBox.Text);
                            command.Parameters.AddWithValue("@surname", surnameBox.Text);
                            command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                            clientCommand.Parameters.AddWithValue("@date_of_birth", datePicker.Value.ToString(DATE_FORMAT));
                            clientCommand.Parameters.AddWithValue("@description", descriptionBox.Text);
                            clientCommand.Parameters.AddWithValue("@link", linkBox.Text);

                            command.Parameters.AddWithValue("@id", User.id);
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
                    else if (!string.IsNullOrEmpty(usernameBox.Text) &&
                       !string.IsNullOrEmpty(passwordBox.Text) &&
                       !string.IsNullOrEmpty(emailBox.Text) &&
                       roleComboBox.SelectedIndex == 1)
                    {
                        using (SQLiteCommand command = new SQLiteCommand(AppConstants.CREATE_USER_VARIABLES, connection))
                        //using (SQLiteCommand skillsCommand = new SQLiteCommand(AppConstants.CREATE_SKILLS, connection))
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

                            command.Parameters.AddWithValue("@id", User.id);

                            command.ExecuteNonQuery();
                            /* try
                             {
                                 command.ExecuteNonQuery();
                                 MessageBox.Show("Τα στοιχεία σας αποθηκεύτηκαν με επιτυχία.");
                             }
                             catch (Exception ex)
                             {
                                 MessageBox.Show("Σφάλμα κατά την αποθήκευση: " + ex.Message);

                             }*/


                            // Retrieve the ID of the newly inserted user
                            int userId;
                            using (SQLiteCommand getUserIdCommand = new SQLiteCommand("SELECT last_insert_rowid()", connection))
                            {
                                userId = Convert.ToInt32(getUserIdCommand.ExecuteScalar());
                            }


                            // Create the command and set its parameters
                            using (SQLiteCommand skillsCommand = new SQLiteCommand(CREATE_SKILLS, connection))
                            {
                                skillsCommand.Parameters.AddWithValue("@id", userId);
                                if (returnFlag(0) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@c", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@c", 0);


                                }
                                if (returnFlag(1) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@css", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@css", 0);


                                }
                                if (returnFlag(2) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@html", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@html", 0);


                                }
                                if (returnFlag(3) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@java", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@java", 0);


                                }
                                if (returnFlag(4) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@javascript", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@javascript", 0);


                                }
                                if (returnFlag(5) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@php", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@php", 0);


                                }
                                if (returnFlag(6) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@python", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@python", 0);


                                }
                                if (returnFlag(7) == 1)
                                {
                                    skillsCommand.Parameters.AddWithValue("@ruby", 1);

                                }
                                else
                                {
                                    skillsCommand.Parameters.AddWithValue("@ruby", 0);


                                }
                                skillsCommand.Parameters.AddWithValue("@other", skillsBox.Text);

                                skillsCommand.ExecuteNonQuery();
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Παρακαλώ συμπληρώστε τα υποχρεωτικά πεδία.");
                    }
                }

        }


        private void getFlag(int flag, int index) 
        {
            if (flag == 0)
            {
                skillsListBox.SetItemChecked(index, false);
            }
            else
            {
                skillsListBox.SetItemChecked(index, true);
            }
        } 

        private int returnFlag (int index) 
        {
             if (skillsListBox.GetItemChecked(index))
             {
                 skillFlag = 1;
             }
             else 
             {
                 skillFlag = 0;

             }
             return skillFlag;
            
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
                portfolioBox.Visible = true;
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
                portfolioBox.Visible = false;
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
