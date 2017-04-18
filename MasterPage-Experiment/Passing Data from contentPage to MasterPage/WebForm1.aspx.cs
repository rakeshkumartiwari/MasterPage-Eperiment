using System;

namespace MasterPage_Experiment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChild_Click(object sender, EventArgs e)
        {
            //If we don't specify <%@MasterType %> directive in WebForm1.aspx page then we have to type cast the Master object.

            //((Site1) Master).TextBoxOnMasterPage.Text = txtChildPage.Text;

            //If  specify <%@MasterType %> directive in WebForm1.aspx page then no need to type cast the Master object.

            Master.TextBoxOnMasterPage.Text = txtChildPage.Text;

        }
    }
}