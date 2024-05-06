using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePlanner
{
    internal class Translations
    {
        public static Dictionary<string, string> TranslationDictionary = new Dictionary<string, string> {
            { "PUBLIC", "Δημόσιο" },
            { "PRIVATE", "Ιδιωτικό"},
            { "WEBSITE", "Ιστοσελίδα"},
            { "ESHOP", "Ηλεκτρονικό κατάστημα"},
            { "PORTAL", "Portal"},
            { "CORPORATE", "Εταιρική"},
            { "WORDPRESS", "Σελίδα Wordpress"},
            { "HOURLY", "Με την ώρα"},
            { "TOTAL", "Σύνολο"},
            { "UNKNOWN", "Άγνωστο"},
            { "LESS_THAN_WEEK", "Λιγότερο από 1 βδομάδα"},
            { "ONE_TO_FOUR_WEEKS", "1 - 4 βδομάδες"},
            { "ONE_TO_THREE_MONTHS", "1 - 3 μήνες"},
            { "THREE_TO_SIX_MONTHS", "3 - 6 μήνες"},
            { "SIX_TO_TWELVE_MONTHS", "6 - 12 μήνες"},
            { "OVER_YEAR", "Πάνω από 1 χρόνος"}
        };

        public static string getTranslationKey(string translation)
        {
            return TranslationDictionary.FirstOrDefault(x => x.Value == translation).Key;
        }
    }
}
