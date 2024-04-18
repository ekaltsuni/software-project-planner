using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;

namespace SoftwarePlanner
{
    internal class AppConstants
    {
        public static readonly string DATE_FORMAT = "yyyy-MM-dd";

        public static readonly string CONNECTION_STRING = "Data source=app-data.db;Version=3";
        SQLiteConnection connection;

        /* SQL queries 
         */

        /* LOGIN 
         */

        public static readonly string RETURN_USER = "SELECT id FROM User WHERE username = @username AND password = @password";
        public static readonly string RETURN_ROLE = "SELECT role FROM User WHERE id = @id";



        /* USER PROFILE FORM
         */

        public static readonly string RETURN_USER_VARIABLES = "SELECT email, username, " +
            "password, name, surname FROM User WHERE id = @id";
       public static readonly string UPDATE_USER_VARIABLES = 
            "UPDATE OR IGNORE User SET username = ?, password = ?, " +
            "email = ?, name = ?, " +
            "surname = ?, gender = ?" +
            " WHERE id = @id";
        public static readonly string CREATE_USER_VARIABLES = "INSERT OR IGNORE INTO User (username, password, email, role, name, surname, gender, signing_date, id) " +
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, @id)";

        // DEVELOPER ONLY FIELDS
        //public static readonly string CREATE_DEVELOPER_VARIABLES = "INSERT OR IGNORE INTO Developer (skills, cv, portfolio_links, id) " +
//"VALUES (?, ?, ?, @id)";
        //public static readonly string RETURN_DEVELOPER_VARIABLES = "SELECT skills, cv, portfolio_links FROM Developer" +
          //  " WHERE id = @id";
        public static readonly string RETURN_SKILLS = "SELECT * FROM Skills WHERE id = @id";
        public static readonly string UPDATE_SKILLS = "UPDATE Skills SET c = ?, css = ?, " +
            "html = ?, java = ?, javascript = ?, php = ?, python = ?, ruby = ?, other = ? " +
            "WHERE id = @id";
        public static readonly string CREATE_SKILLS = "INSERT INTO Skills (c, css, html, java, javascript, php, python, ruby, other) VALUES " +
            "(?, ?, ?, ?, ?, ?, ?, ?, @id)";
        public static readonly string UPDATE_DEVELOPER_VARIABLES = "UPDATE OR IGNORE Developer SET" +
            "skills = ?, cv = ?, portfolio_links = ?" +
            "WHERE id = @id";
        public static readonly string RETURN_DEV_SIMPLE = @"SELECT u.username
                                                                FROM User u
                                                                INNER JOIN Developer d
                                                                    ON u.id = d.id
                                                                WHERE u.username LIKE @username";
        public static readonly string RETURN_DEV_ADVANCED = @"SELECT u.username
                                                                FROM User u
                                                                INNER JOIN Developer d
                                                                    ON u.id = d.id
                                                                WHERE u.username LIKE @username
                                                                    AND u.signing_date >= @dateBefore AND u.signing_date <= @dateAfter
                                                                    AND d.rating BETWEEN @minRating AND @maxRating
                                                                    AND d.project_count BETWEEN @minCount AND @maxCount";

        // CUSTOMER ONLY FIELDS
        public static readonly string CREATE_CLIENT_VARIABLES = "INSERT OR IGNORE INTO Client (date_of_birth, description, link, id) " +
    "VALUES (?, ?, ?, @id)";
        public static readonly string RETURN_CLIENT_VARIABLES = "SELECT date_of_birth, link, description FROM Client " +
            "WHERE id = @id";
        public static readonly string UPDATE_CLIENT_VARIABLES = "UPDATE OR IGNORE Client SET " +
            "date_of_birth = ?, link = ?, description = ? " +
            "WHERE id = @id";
        public static readonly string RETURN_CLIENT_SIMPLE = @"SELECT u.username
                                                                FROM User u
                                                                INNER JOIN Client c
                                                                    ON u.id = c.id
                                                                WHERE u.username LIKE @username
                                                                    OR c.description LIKE @username";
        public static readonly string RETURN_CLIENT_ADVANCED = @"SELECT u.username
                                                                FROM User u
                                                                INNER JOIN Client c
                                                                    ON u.id = c.id
                                                                WHERE (u.username LIKE @username
                                                                    OR c.description LIKE @username)
                                                                    AND u.signing_date >= @dateBefore AND u.signing_date <= @dateAfter";

        // PROJECT ONLY FIELDS
        public static readonly string RETURN_PROJECT_SIMPLE = @"SELECT title
                                                                FROM Project p
                                                                WHERE p.title LIKE @title
                                                                    OR p.description LIKE @title";
        public static readonly string RETURN_PROJECT_ADVANCED = @"SELECT title
                                                                FROM Project p
                                                                INNER JOIN ProjectCategory pc
                                                                    ON pc.project_id = p.id
                                                                INNER JOIN ProjectTechnology pt
                                                                    ON pt.project_id = p.id
                                                                WHERE (p.title LIKE @title
                                                                    OR p.description LIKE @title)
                                                                    AND pc.category LIKE @category AND pc.subcategory LIKE @subcategory
                                                                    AND p.date >= @dateBefore AND p.date <= @dateAfter
                                                                    AND pt.category IN @technologies";
        public static readonly string SAVE_PROJECT = @"INSERT INTO Project (title, description, price_visibility, max_price, bidding_duration) 
                                                       VALUES (@title, @description, @price_visibility, @max_price, @bidding_duration)";

        // DROPDOWN VALUES
        public static readonly string RETURN_PROJECT_TYPES = "SELECT type FROM ProjectType";
        public static readonly string RETURN_PROJECT_CATEGORIES = "SELECT name FROM ProjectCategory";
        public static readonly string RETURN_PROJECT_PAYMENT = "SELECT type FROM ProjectPayment";
        public static readonly string RETURN_PROJECT_DURATION = "SELECT type FROM ProjectDuration";
        public static readonly string RETURN_SUBCATEGORIES_BY_CATEGORY = @"SELECT ps.name
                                                                           FROM ProjectSubCategory ps
                                                                           INNER JOIN ProjectCategory pc
                                                                                ON pc.id = ps.category_id
                                                                           WHERE pc.name = @categoryName";

        // UPDATE FIELDS VISIBILITY TO-DO


        public static class User
        {
            private static int _id;
            public static int id
            {
                get { return _id; }
                set { _id = value; }
            }

            private static string _role;
            public static string role
            {
                get { return _role; }
                set { _role = value; }
            }
        }

        public static class Role
        {
            private static bool _isDeveloper;
            public static bool isDeveloper
            {
                get { return _isDeveloper; }
                set {_isDeveloper = value; }
            }

            private static bool _isClient;
            public static bool isClient
            {
                get { return _isClient; }
                set { _isClient = value; }
            }

            private static bool _isVisitor;
            public static bool isVisitor
            {
                get { return _isVisitor; }
                set { _isVisitor = value; }
            }
        }


        public enum UserFilterOption
        {
            DEVELOPER,
            CLIENT
        }

        public static Dictionary<string, string> Translations = new Dictionary<string, string> {
            { "PUBLIC", "Δημόσιο" },
            { "PRIVATE", "Ιδιωτικό"},
            { "WEBSITE", "Website"},
            { "ESHOP", "Ηλεκτρονικό κατάστημα"},
            { "PORTAL", "Portal"},
            { "CORPORATE", "Εταιρικό"},
            { "WORDPRESS", "Σελίδα Wordpress"},
            { "HOURLY", "Με την ώρα"},
            { "TOTAL", "Σύνολο"},
            { "UNKNOWN", "Άγνωστο"},
            { "LESS_THAN_WEEK", "Λιγότερο από 1 βδομάδα"},
            { "ONE_TO_FOUR_WEEKS", "1 - 4 βδομάδες"},
            { "ONE_TO_THREE_MONTHS", "1 - 3 μήνες"},
            { "THREE_TO_SIX_MONTHS", "3 - 6 μήνες"},
            { "SIX_TO_TWELVE_MONTHS", "6 - 12 μήνες"},
            { "OVER_YEAR", "1+ χρόνος"}
        };

        public static void getRole()
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
    }
    
}
