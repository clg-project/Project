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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (login_user.SelectedIndex == 0)
            {
                String s1 = "select *from Admin where Admin_id='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                Boolean b1=Login1(s1);
                if (b1 == true)
                {
                    Session["admin"] = TextBox1.Text;
                    Response.Redirect("~/Admin/Admin_homepage.aspx");
                }
            }
            else if (login_user.SelectedIndex == 1)
            {
                String s2 = "select *from Faculty where F_id='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                Boolean b2= Login1(s2);
                if (b2 == true)
                {
                    Session["faculty"] = TextBox1.Text;
                    Response.Redirect("~/Faculty/Faculty_homepage.aspx");
                }
                
            }
            else if (login_user.SelectedIndex == 2)
            {
                String s3 = "select *from Student where Student_id='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                Boolean b3= Login1(s3);
                if (b3 == true)
                {
                    Session["student"] = TextBox1.Text;
                    Response.Redirect("~/Student/Student_homepage.aspx");
                }
            }          
        }
        public bool Login1(String s)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(s, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cn.Close();
                    return true;
                }
                else
                {
                    cn.Close();
                    Login_Error.Visible = true;
                    Login_Error.Text = "*Wrong Username or Password";
                    return false;
                }
            }
            catch(Exception ex)
            {
                Login_Error.Text = "Something Went Wrong. Plz try again after sometimes" + ex.Message;
                return false;
            }
          
        }
    }
}