using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Project.Faculty
{
    public partial class add_category : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            string s = "insert into category values(@cname)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@cname", textbox1.Text);
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                Label1.Text = "Category not added";
            }
            else
            {
                Label1.Text = "Category addded";
            }
            cn.Close();
        }
    }
}