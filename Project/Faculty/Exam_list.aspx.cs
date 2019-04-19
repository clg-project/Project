using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Project.Faculty
{
    public partial class Exam_list : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        String faculty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["faculty"] == null)
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
            SqlCommand cmd = new SqlCommand("select *from exam where F_id=@fid", cn);
            cmd.Parameters.AddWithValue("@fid", faculty);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "deleteexam")
            {
                try
                {
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Exam where [Exam-id]=@eid", cn);
                    cmd.Parameters.AddWithValue("@eid", e.CommandArgument);
                    int i = cmd.ExecuteNonQuery();
                    if (i <= 0)
                    {
                        resultmsg.Text = "Exam not deleted";
                    }
                    cn.Close();
                    getdata();
                }
                catch(Exception ex)
                {
                    resultmsg.Text = "Something Went Wrong.Error: " + ex.Message;
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}