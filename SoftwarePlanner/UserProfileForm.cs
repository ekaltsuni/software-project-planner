using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwarePlanner
{
    public partial class UserProfileForm : Form
    {
        String email, username, password, role, name, surname, gender, skills, cv, portfolio;
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
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);

                    command.Parameters.AddWithValue("@id", User.id);
                       
                    command.ExecuteNonQuery();
                    MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");

                }
            }
            
            else if (Role.isClient)
            {

                using (SQLiteCommand command = new SQLiteCommand(AppConstants.UPDATE_USER_VARIABLES, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", usernameBox.Text);
                    command.Parameters.AddWithValue("@password", passwordBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);
                    command.Parameters.AddWithValue("@name", nameBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);

                    command.Parameters.AddWithValue("@id", User.id);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Οι αλλαγές αποθηκεύτηκαν με επιτυχία.");

                }
            }
            else if (Role.isVisitor)
            {
                //todo inserts
            }
        }

        private void updateParameters(String variable, SQLiteCommand command, String value)
        {
            if (!string.IsNullOrEmpty(variable))
                command.Parameters.AddWithValue(value, variable);
            else
                command.Parameters.AddWithValue(value, DBNull.Value);
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex == 0)
            {
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
            }
            else if (roleComboBox.SelectedIndex == 1)
            {
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
            }
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
            if (Role.isDeveloper == true)
            {
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox18.Visible = false;
                developerCheckedListBox.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Developer";
                αποσύνδεσηToolStripMenuItem.Visible = true;
            }
            else if (Role.isClient == true)
            {
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox18.Visible = true;
                clientCheckedListBox.Visible = true;
                roleComboBox.Enabled = false;
                roleComboBox.Text = "Πελάτης";
                αποσύνδεσηToolStripMenuItem.Visible = true;
            }
            else
            {
                roleComboBox.Enabled = true;
            }
        }
    }
}
