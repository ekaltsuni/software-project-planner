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
    public partial class ratingForm : Form
    {
        private bool finished = false;
        private bool ratingGiven = false;
        private int userId = -1;
        private int projectId = -1;
        private int rating = 0;
        private DataGridViewCell cell = null;

        public ratingForm(string projectName, DataGridViewCell cell)
        {
            InitializeComponent();
            this.cell = cell;
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING)) 
            using (SQLiteCommand command = new SQLiteCommand(RETURN_PROJECT_FULL, connection))
            using (SQLiteCommand userCommand = new SQLiteCommand(RETURN_USER_NAME, connection))
            { 
                connection.Open();
                command.Parameters.AddWithValue("@title", projectName);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        projectBox.Text = reader.GetString(reader.GetOrdinal("title"));
                        projectId = reader.GetInt32(reader.GetOrdinal("project_id"));
                        finished = reader.GetInt32(reader.GetOrdinal("finished")) == 1;
                        try
                        {
                            userId = reader.GetInt32(reader.GetOrdinal("user_id"));
                        }
                        catch (Exception) { };
                    }
                }
                if (userId != -1)
                {
                    userCommand.Parameters.AddWithValue("@id", userId);
                    using (SQLiteDataReader reader = userCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            devBox.Text = reader.GetString(reader.GetOrdinal("username"));
                        }
                    }
                }
                else devBox.Text = "Χωρίς ανάθεση";
            }
            if (finished)
            {
                completionButton.Enabled = false;
                commentBox.Enabled = false;
            }
        }

        private void star1_Click(object sender, EventArgs e)
        {
            changeRating(1);
        }

        private void star2_Click(object sender, EventArgs e)
        {
            changeRating(2);
        }

        private void star3_Click(object sender, EventArgs e)
        {
            changeRating(3);
        }

        private void star4_Click(object sender, EventArgs e)
        {
            changeRating(4);
        }

        private void star5_Click(object sender, EventArgs e)
        {
            changeRating(5);
        }

        private void changeRating(int rating)
        {
            if (!finished)
            {
                this.rating = rating;
                ratingGiven = true;
                for (int i = 1; i <= rating; i++)
                {
                    PictureBox star = this.Controls["star" + i] as PictureBox;
                    star.ImageLocation = "./images/full_star.png";
                }
                for (int i = rating + 1; i <= 5; i++)
                {
                    PictureBox star = this.Controls["star" + i] as PictureBox;
                    star.ImageLocation = "./images/empty_star.png";
                }
            }
        }

        private void completionButton_Click(object sender, EventArgs e)
        {
            if (!finished)
            {
                if (!ratingGiven)
                {
                    MessageBox.Show("Πρέπει να δώσετε μία βαθμολογία στον developer.");
                    return;
                }
                if (commentBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Πρέπει να γράψετε κριτική για τον developer.");
                    return;
                }
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(UPDATE_USER_RATING, connection))
                using (SQLiteCommand completeCommand = new SQLiteCommand(COMPLETE_PROJECT, connection))
                using (SQLiteCommand userCommand = new SQLiteCommand(UPDATE_RATING_AND_COUNT, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.Parameters.AddWithValue("@project_id", projectId);
                    command.Parameters.AddWithValue("@rating", rating);
                    command.Parameters.AddWithValue("@comment", commentBox.Text.Trim());
                    completeCommand.Parameters.AddWithValue("@project_id", projectId);
                    userCommand.Parameters.AddWithValue("@rating", rating);
                    userCommand.Parameters.AddWithValue("@id", userId);

                    command.ExecuteNonQuery();
                    completeCommand.ExecuteNonQuery();
                    userCommand.ExecuteNonQuery();

                    MessageBox.Show("Η κριτική δημοσιεύθηκε.");
                    finished = true;
                    completionButton.Enabled = false;
                    commentBox.Enabled = false;
                    cell.Value = "Ναι";
                }
            }
        }
    }
}
