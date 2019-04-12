using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Project
{
    
    public partial class Result : System.Web.UI.Page
    {
        string s;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
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

            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Result where Student_id=@sid", cn);
            cmd.Parameters.AddWithValue("@sid",s);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            
           
            cn.Close();
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("select Exam_name from Exam", cn);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}