using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Faculty
{
    public partial class select_exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = DropDownList1.SelectedValue;
            Response.Redirect("~/Faculty/add_question.aspx?exam_id="+s);
        }

        protected void show_Click(object sender, EventArgs e)
        {
            string s = DropDownList1.SelectedValue;
            Response.Redirect("show_question.aspx?exam_id=" + s);
        }
    }
}