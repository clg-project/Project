using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Project
{
    public partial class Edit_profile_faculty : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionstring"].ConnectionString);
        string s;
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
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Faculty where F_id=@fid", cn);
            cmd.Parameters.AddWithValue("@fid",s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox2.Text = dr["F_name"].ToString();
                TextBox3.Text = dr["Email_id"].ToString();
            }
            cn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update Faculty set F_name=@fname,Email_id=@email where F_id=@fid", cn);       
            cmd.Parameters.AddWithValue("@email", TextBox3.Text);
            cmd.Parameters.AddWithValue("@fname", TextBox2.Text);
            cmd.Parameters.AddWithValue("@fid", s);
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                resulmsg.Text = "Profile not updated";
            }
            else
            {
                resulmsg.Text = "Profile Updated";
            }
            cn.Close();
        }
    }
}