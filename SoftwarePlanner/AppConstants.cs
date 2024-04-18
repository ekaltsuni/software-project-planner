using System.Data.SQLite;
using static SoftwarePlanner.SQLConstants;

namespace SoftwarePlanner
{
    internal class AppConstants
    {
        public static readonly string DATE_FORMAT = "yyyy-MM-dd";



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

        public static void getRole()
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(RETURN_ROLE, connection))
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
