using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Project.Home
{
    
    public partial class New_password : System.Web.UI.Page
    {
        string s,email;
        int id;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            s = Request.QueryString["uid"];
            if (Request.QueryString["uid"] == null)
            {
                Response.Redirect("login.aspx");          
            }
            cn.Open();
            string s1 = "select studentId from tblResetPasswordRequests where Id=@uid";
            SqlCommand cmd = new SqlCommand(s1, cn);
            cmd.Parameters.AddWithValue("@uid", s);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                id = (int)dr["studentID"];
                // Response.Redirect("login.aspx");
            }
            else
            {
                Resultmsg.Text = "Wrong";
            }
            cn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "update student set password='" + TextBox1.Text + "' where Student_id='" + id + "'";
                cn.Open();
                SqlCommand cmd = new SqlCommand(s, cn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Resultmsg.Text = "Password changed successfully";
                }
                else
                {
                    Resultmsg.Text = "Passsword doesn't changed";
                }
            }
            catch(Exception xe)
            {
                Resultmsg.Text = "Something Went Wrong.plz try again in some times" + xe.Message;
            }
        }
    }
}