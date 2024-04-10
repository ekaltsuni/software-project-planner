using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePlanner
{
    internal class AppConstants
    {
        public enum ProjectType
        {
            PUBLIC,
            PRIVATE
        }

        public enum ProjectCategory
        {
            WERBSITE,
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
