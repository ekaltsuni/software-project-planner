using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SoftwarePlanner.AppConstants;

namespace SoftwarePlanner
{
    public partial class HomeForm : ParentForm
    {
        public HomeForm()
        {
            InitializeComponent();
            userFilter.Items.Add(UserFilterOption.DEVELOPER);
            userFilter.Items.Add(UserFilterOption.CLIENT);
            userFilter.SelectedItem = UserFilterOption.DEVELOPER;
            // TODO: Get these values from DB
            categoryDropdown.Items.Add(ProjectCategory.WEBSITE);
            categoryDropdown.Items.Add(ProjectCategory.ESHOP);
            // TODO: Filter based on category (will be easy with DB)
            subcategoryDropdown.Items.Add(ProjectSubCategory.CORPORATE);
            subcategoryDropdown.Items.Add(ProjectSubCategory.PORTAL);
            subcategoryDropdown.Items.Add(ProjectSubCategory.WORDPRESS);
        }

        private void advancedSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (advancedSearchCheckBox.Checked)
            {
                advancedSearchGroup.Visible = true;
                if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.DEVELOPER))
                {
                    devAdvancedSearchGroup.Visible = true;
                }
            }
            else
            {
                advancedSearchGroup.Visible = false;
                devAdvancedSearchGroup.Visible = false;
            }    
        }

        private void userFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.CLIENT))
            {
                devAdvancedSearchGroup.Visible = false;
            }
            else if (((UserFilterOption)userFilter.SelectedItem).Equals(UserFilterOption.DEVELOPER) && advancedSearchCheckBox.Checked)
            {
                devAdvancedSearchGroup.Visible = true;
            }
        }
    }
}
