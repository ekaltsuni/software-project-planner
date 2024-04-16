using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // DEVELOPER ONLY FIELDS
        public static readonly string RETURN_DEVELOPER_VARIABLES = "SELECT skills, cv, portfolio FROM Developer" +
            " WHERE id = @id";
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

        public enum ProjectType
        {
            PUBLIC,
            PRIVATE
        }

        public enum ProjectCategory
        {
            WEBSITE,
            ESHOP
        }

        public enum ProjectSubCategory 
        {
            PORTAL,
            CORPORATE,
            WORDPRESS
        }

        public enum ProjectPaymentType
        {
            HOURLY,
            TOTAL
        }

        public enum ProjectDuration
        {
            UNKNOWN,
            LESS_THAN_WEEK,
            ONE_TO_FOUR_WEEKS,
            ONE_TO_THREE_MONTHS,
            THREE_TO_SIX_MONTHS,
            SIX_TO_TWELVE_MONTHS,
            OVER_YEAR
        }
    }
}
