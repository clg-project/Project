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
    public partial class Faculty_Registration : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            errfid.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select F_id from faculty", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr[0].ToString() == TextBox1.Text)
                    {
                        errfid.Text = "*Faculty Id already exist, Try different Faculty Id";
                        i++;
                    }

                }

            }
            cn.Close();
            if (i == 0)
            {

                try
                {
                    String s = "insert into Faculty values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "')";
                    cn.Open();
                    SqlCommand cmd1 = new SqlCommand(s, cn);
                    cmd1.ExecuteNonQuery();
                    cn.Close();
                    Label2.Text = "Faculty added";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
                catch (Exception ex)
                {
                    Label2.Text = "Faculty not added" + ex.Message;
                }
            }
        }
    }
}