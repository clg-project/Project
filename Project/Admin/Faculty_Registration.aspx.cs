using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Project
{
    public partial class Faculty_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {            
                String s = "insert into Faculty values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "')";
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand(s, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                Label2.Text = "Faculty added";
            }
            catch(Exception ex)
            {
                Label2.Text = "Faculty not added"+ex.Message;
            }
        }
    }
}