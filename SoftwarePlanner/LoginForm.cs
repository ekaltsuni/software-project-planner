using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static SoftwarePlanner.AppConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwarePlanner
{
    public partial class LoginForm : Form
    {
        public string role;

        public LoginForm()
        {
            InitializeComponent();
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
                            //HomeForm home = new HomeForm();
                            //home.Show();
                            
                            UserProfileForm userProfile = new UserProfileForm();
                            userProfile.Show();

                        }
                        else MessageBox.Show("Λανθασμένο όνομα χρήστη ή κωδικός.");
                    }
                }
            }
            else MessageBox.Show("Παρακαλώ συμπληρώστε όνομα & κωδικό.");
        }

        private void getRole()
        {
            using (SQLiteConnection connection = new SQLiteConnection(AppConstants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(AppConstants.RETURN_ROLE, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", User.id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User.role = reader.GetString(reader.GetOrdinal("role"));
                    }
                }
            }
        }

        private void login()
        {
            if (User.role.Equals("developer"))
            {
                Role.isDeveloper = true;
                Role.isClient = false;

            }
            else if (User.role.Equals("client"))
            {
                Role.isDeveloper = false;
                Role.isClient = true;
            }
        }
    }
}
