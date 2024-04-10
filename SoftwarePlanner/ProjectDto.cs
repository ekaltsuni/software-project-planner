using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SoftwarePlanner.AppConstants;

namespace SoftwarePlanner
{
    internal class ProjectDto
    {
        private string title;
        private string description;
        private ProjectType type;
        private bool devPriceIsVisible;
        private ProjectCategory category;
        private ProjectSubCategory subCategory;
        private ProjectPaymentType paymentType;
        // Saved in the smallest subdivision e.g. cents
        private int maxPrice;
        private ProjectDuration duration;
        private List<string> tags;
    }
}
