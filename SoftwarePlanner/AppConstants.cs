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

        // CUSTOMER ONLY FIELDS
        public static readonly string RETURN_CLIENT_VARIABLES = "SELECT date_of_birth, links, description FROM Client" +
            "WHERE id = @ id";
        public static readonly string UPDATE_CLIENT_VARIABLES = "UPDATE OR IGNORE Client SET" +
            "date_of_birth = ?, links = ?, description = ?" +
            "WHERE id = @ id";
     

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
