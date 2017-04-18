using System;
using System.Web.UI.HtmlControls;
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

        public Button RedButton
        {
            get { return btnRed; }
        }
        public Button YellowButton
        {
            get { return btnYellow; }
        }
        public Button GreenButton
        {
            get { return btnGreen; }
        }
        public Button NormalButton
        {
            get { return btnNormal; }
        }

        public HtmlGenericControl MasterPageBody
        {
            get { return MasterBody; }
        }


        //protected void Page_InitComplete(object sender, EventArgs e)
        //{

        //}
        //protected void Page_PreInit(object sender, EventArgs e)
        //{

        //}
      

        //protected void Page_Init(object sender, EventArgs e)
        //{

        //}
        //protected void Page_PreRenderComplete(object sender, EventArgs e)
        //{

        //}
        //protected void Page_PreLoad(object sender, EventArgs e)
        //{

        //}
        //protected void Page_PreRender(object sender, EventArgs e)
        //{

        //}
        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //}
        //protected void Page_Unload(object sender, EventArgs e)
        //{

        //}
        //protected void Page_SaveStateComplete(object sender, EventArgs e)
        //{

        //}
    }
}