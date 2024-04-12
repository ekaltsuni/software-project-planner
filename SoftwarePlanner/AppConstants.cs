using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

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

        public static readonly string RETURN_USER_VARIABLES = "SELECT email, username, name, surname FROM User WHERE id = @id";
        public static readonly string UPDATE_EMAIL = "UPDATE User SET email = @email WHERE id = @id";
        public static readonly string UPDATE_PASSWORD = "UPDATE User SET password = @password WHERE id = @id";
        public static readonly string UPDATE_NAME = "UPDATE User SET name = @name WHERE id = @id";
        public static readonly string UPDATE_SURNAME = "UPDATE User SET surname = @surname WHERE id = @id";
        public static readonly string UPDATE_GENDER = "UPDATE User SET gender = @gender WHERE id = @id";

        // DEVELOPER ONLY FIELDS
        public static readonly string UPDATE_SKILLS = "UPDATE Developer SET skills = @skills WHERE id = @id";
        public static readonly string UPDATE_CV = "UPDATE Developer SET cv = @cv WHERE id = @id";
        public static readonly string UPDATE_PORTFOLIO = "UPDATE User SET portfolio_links = @portfolio_links WHERE id = @id";

        // CUSTOMER ONLY FIELDS
        public static readonly string UPDATE_DATE_OF_BIRTH = "UPDATE Client SET date_of_birth = @date_of_birth WHERE id = @id";
        public static readonly string UPDATE_LINKS = "UPDATE Client SET links = @links WHERE id = @id";
        public static readonly string UPDATE_DESCRIPTION = "UPDATE Client SET description = @description WHERE id = @id";

        // UPDATE FIELDS VISIBILITY






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

        public enum USER_VARIABLES
        {
            
            EMAIL,
            USERNAME,
            NAME,
            SURNAME
            //GENDER

        }

        public static readonly Dictionary<USER_VARIABLES, string> USER_VARIABLE_CODES = new Dictionary<USER_VARIABLES, string>()
        {
            {USER_VARIABLES.EMAIL, "email"},
            {USER_VARIABLES.USERNAME, "username"},
            {USER_VARIABLES.NAME, "name"},
            {USER_VARIABLES.SURNAME, "surname"},
            //{USER_VARIABLES.GENDER, "gender"},
        };


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
