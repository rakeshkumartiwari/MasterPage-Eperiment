using System;

namespace MasterPage_Experiment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Master.RedButton.Click += btnRed_Click;
            Master.YellowButton.Click += btnYellow_Click;
            Master.GreenButton.Click += btnGreen_Click;
            Master.NormalButton.Click += NormalButton_Click;
            
        }
        protected void btnRed_Click(object sender, EventArgs e)
        {
            Master.MasterPageBody.Attributes.Add("style", "background-color: red");
            
        }
        protected void btnYellow_Click(object sender, EventArgs e)
        {
            Master.MasterPageBody.Attributes.Add("style", "background-color: yellow");
        }
        protected void btnGreen_Click(object sender, EventArgs e)
        {
            Master.MasterPageBody.Attributes.Add("style", "background-color: green");
        }
        protected void NormalButton_Click(object sender, EventArgs e)
        {
            Master.MasterPageBody.Attributes.Add("style", "background-color: white");
        }
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



        //protected void Page_InitComplete(object sender, EventArgs e)
        //{

        //}
        //protected void Page_PreInit(object sender, EventArgs e)
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