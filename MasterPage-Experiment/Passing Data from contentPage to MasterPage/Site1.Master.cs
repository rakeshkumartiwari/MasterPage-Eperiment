using System;
using System.Web.UI.WebControls;

namespace MasterPage_Experiment
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox TextBoxOnMasterPage
        {
            get
            {
                return txtOnMasterPage;

            }
        }
      
    }
}