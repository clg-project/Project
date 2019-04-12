using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.Student
{
    public partial class Reset_password_student : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        string s;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                s = Session["student"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update Student set Password=@pass where Student_id=@sid",cn);
            cmd.Parameters.AddWithValue("@pass", TextBox1.Text);
            cmd.Parameters.AddWithValue("@sid", s);
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                Label1.Text = "Password is not updated";
            }
            else
            {
                Label1.Text = "Password is updated";
            }
        }
    }
}