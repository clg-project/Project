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
    public partial class show_question : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            String s1 = Request.QueryString["exam_id"];
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            if(!IsPostBack)
            getquestion(Convert.ToInt32(s1));
        }

        public void getquestion(int e)
        {
            using (cn)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select  *from Question where Exam_id=@qid",cn);
                cmd.Parameters.AddWithValue("@qid", e);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                cn.Close();
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string s1 = Request.QueryString["exam_id"];
            if(e.CommandName== "deleteexamquestion")
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Question where Que_id=@qid",cn);
                    cmd.Parameters.AddWithValue("@qid",Convert.ToInt32(e.CommandArgument));
                    int i = cmd.ExecuteNonQuery();
                    cn.Close();
                getquestion(Convert.ToInt32(s1));
            }
        }
    }
}