using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.Faculty
{
    public partial class add_question : System.Web.UI.Page
    {
        String id;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            id = Request.QueryString["exam_id"];
            if (id==null)
            {
                Response.Redirect("select_exam.aspx");
            }
        }
        protected void add_que_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String s = "insert into Question values(@que,@op1,@op2,@op3,@op4,@ans,@eid)";
                SqlCommand cmd = new SqlCommand(s, cn);
                cmd.Parameters.AddWithValue("@que", question.Text);
                cmd.Parameters.AddWithValue("@op1", option1.Text);
                cmd.Parameters.AddWithValue("@op2", option2.Text);
                cmd.Parameters.AddWithValue("@op3", option3.Text);
                cmd.Parameters.AddWithValue("@op4", option4.Text);
                cmd.Parameters.AddWithValue("@ans", answer.Text);
                cmd.Parameters.AddWithValue("@eid", int.Parse(id));
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    result.Text = "Question added successfully";
                }
                else
                {
                    result.Text = "Please try again!";
                }
            }
            catch(Exception ex)
            {
                result.Text = "Something is Wrong.Try again after sometimes.Error: " + ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Faculty/add_question.aspx?exam_id=" + id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("show_question.aspx?exam_id="+id);
        }
    }
}