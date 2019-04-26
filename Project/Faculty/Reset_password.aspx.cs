using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.Faculty
{
    public partial class Reset_password : System.Web.UI.Page
    {
        string s;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionstring"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                s = Session["faculty"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update Faculty set password=@pass where F_id=@fid", cn);
            cmd.Parameters.AddWithValue("@fid", s);
            cmd.Parameters.AddWithValue("@pass", TextBox1.Text);
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                Label1.Text = "Password not changed";
            }
            else
            {
                Label1.Text = "Password chnaged successfully";

            }
            cn.Close();
        }
    }
}