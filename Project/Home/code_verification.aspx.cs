using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Home
{
    public partial class code_verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Application["code"]==TextBox1.Text)
            {
                Response.Redirect("New_password.aspx");
            }
            else
            {
                Resultmsg.Text = "Not Valid";
            }
        }
    }
}