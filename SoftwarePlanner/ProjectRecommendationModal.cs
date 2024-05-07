using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.SQLConstants;
using static SoftwarePlanner.AppConstants;
namespace SoftwarePlanner
{
    public partial class ProjectRecommendationModal : Form
    {
        private int projectId;
        private int userPage = 0;

        public ProjectRecommendationModal(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            nextUserPage.Enabled = false;
            previousUserPage.Enabled = false;
        }

        private void searchUserBox_TextChanged(object sender, EventArgs e)
        {
            generalUserSearch();
        }

        private void userTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = userTable.CurrentRow.Cells[0].Value.ToString().Trim();
            if (MessageBox.Show(
                   "Θέλετε να προτείνετε το έργο στον/στην " + username,
                   "Software Planner",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(UPDATE_NOTIFICATIONS, connection))
                using (SQLiteCommand userCommand = new SQLiteCommand(RETURN_USER_ID, connection))
                {
                    connection.Open();
                    userCommand.Parameters.AddWithValue("username", username);
                    using (SQLiteDataReader reader = userCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int targetId = reader.GetInt32(reader.GetOrdinal("id"));
                            command.Parameters.AddWithValue("user", targetId);
                            command.Parameters.AddWithValue("project", projectId);
                            command.Parameters.AddWithValue("actor", User.id);
                            if (targetId == User.id)
                            {
                                MessageBox.Show("Δεν μπορείτε να προτείνετε στον εαυτό σας.", "Software Planner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Η ειδοποίηση στάλθηκε.");
                                userTable.Rows.Clear();
                                searchUserBox.Clear();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Κάτι πήγε λάθος. Δοκιμάστε ξανά αργότερα.", "Software Planner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void nextUserPage_Click(object sender, EventArgs e)
        {
            userPage++;
            previousUserPage.Enabled = true;
            generalUserSearch();
        }

        private void previousUserPage_Click(object sender, EventArgs e)
        {
            userPage--;
            generalUserSearch();
            if (userPage == 0)
            {
                previousUserPage.Enabled = false;
            }
        }

        private void generalUserSearch()
        {
            userTable.Rows.Clear();
            string username = searchUserBox.Text;
            if (username.Equals("")) userTable.Rows.Clear();
            else
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(RETURN_DEV_SIMPLE, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("username", "%" + username + "%");
                    command.Parameters.AddWithValue("@page", userPage * 10);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                            if (count < 10)
                            {
                                userTable.Rows.Add(reader.GetString(reader.GetOrdinal("username")));
                            }
                        }
                        if (count > 10) nextUserPage.Enabled = true;
                        else nextUserPage.Enabled = false;
                    }
                }
            }
        }
    }
}
