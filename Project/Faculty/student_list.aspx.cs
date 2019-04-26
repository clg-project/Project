using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Project.Faculty
{
    public partial class student_list : System.Web.UI.Page
    {
        string faculty;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                faculty = Session["faculty"].ToString();
            }
            if (!IsPostBack)
            {
                getdata();
            }
        }
        public void getdata()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from student where F_id=@fid", cn);
            cmd.Parameters.AddWithValue("@fid", faculty);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "deletestudent")
            {
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("delete from Result where Student_id=@sid", cn);
                cmd1.Parameters.AddWithValue("@sid", e.CommandArgument);
                int i1 = cmd1.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand("delete from Student where Student_id=@sid", cn);
                cmd.Parameters.AddWithValue("@sid", e.CommandArgument);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    resultmsg.Text = "Student not deleted";
                }
                else
                {
                    //resultmsg.Text = "Student deleted";
                }
                cn.Close();
                getdata();
            }
        }
    }
}