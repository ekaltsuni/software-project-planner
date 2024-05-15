using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SoftwarePlanner.SQLConstants;

namespace SoftwarePlanner
{
    internal class Translations
    {
        public static string getTranslation(string key)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(GET_TRANSLATION, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@key", key);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.GetString(reader.GetOrdinal("value"));
                }
            }
            return "";
        }

        public static string getTranslationKey(string translation)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING)) 
            using (SQLiteCommand command = new SQLiteCommand(GET_KEY, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@value", translation);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.GetString(reader.GetOrdinal("key"));
                }
            }
            return "";
        }
    }
}
