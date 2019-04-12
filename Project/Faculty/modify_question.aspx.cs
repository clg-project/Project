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
    public partial class modify_question : System.Web.UI.Page
    {
        
        string eid;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = Request.QueryString["qid"];
                if (s == null)
                {
                    Response.Redirect("Faculty_homepage.aspx");
                }
                
                int qid = Convert.ToInt32(s);
                getQuestion(qid);
            }
            eid = Request.QueryString["exam_id"];
        }
        public void getQuestion(int qid)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select *from Question where Que_id=@qid",cn);
                cmd.Parameters.AddWithValue("@qid", qid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Textbox1.Text = dr["Question"].ToString();
                    Textbox2.Text = dr["Option1"].ToString();
                    Textbox3.Text = dr["Option2"].ToString();
                    Textbox4.Text = dr["Option3"].ToString();
                    Textbox5.Text = dr["Option4"].ToString();
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                Resultmsg.Text = ex.Message;
                cn.Close();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string s = Request.QueryString["qid"];
                cn.Open();
                SqlCommand cmd = new SqlCommand("update Question set Question=@que,Option1=@op1,Option2=@op2,Option3=@op3,Option4=@op4,Answer=@ans where Que_id=@qid", cn);
                cmd.Parameters.AddWithValue("@que", Textbox1.Text);
                cmd.Parameters.AddWithValue("@op1", Textbox2.Text);
                cmd.Parameters.AddWithValue("@op2", Textbox3.Text);
                cmd.Parameters.AddWithValue("@op3", Textbox4.Text);
                cmd.Parameters.AddWithValue("@op4", Textbox5.Text);
                cmd.Parameters.AddWithValue("@ans", radioanswer.SelectedValue);
                cmd.Parameters.AddWithValue("@qid", Convert.ToInt32(s));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Resultmsg.Text = i.ToString();
                    Response.Redirect("~/Faculty/show_question.aspx?exam_id="+eid);
                }
                else
                {
                    Resultmsg.Text = "Something Went Wrong.plz try again.";
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                Resultmsg.Text = ex.Message;
                cn.Close();
            }
        }
    }
}