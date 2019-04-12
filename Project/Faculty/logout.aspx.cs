using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Faculty
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Response.Redirect("~/Home/login.aspx");
            }
        }
    }
}