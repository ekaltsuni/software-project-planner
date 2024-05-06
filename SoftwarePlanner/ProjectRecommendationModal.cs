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

namespace SoftwarePlanner
{
    public partial class ProjectRecommendationModal : Form
    {
        public ProjectRecommendationModal()
        {
            InitializeComponent();
        }

        private void searchUserBox_TextChanged(object sender, EventArgs e)
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
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userTable.Rows.Add(reader.GetString(reader.GetOrdinal("username")));
                        }
                    }
                }
            }
        }
    }
}
