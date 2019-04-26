using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.Student
{
    public partial class Exam_detail : System.Web.UI.Page
    {
        string s;
        string eid;
        string sid;
        DateTime start_date, end_date;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            p2.Visible = false;
            eid = Request.QueryString["exam_id"];
            sid = Session["student"].ToString();
            if (Session["student"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                s = Session["student"].ToString();
            }

            if (!(Session["exam_track"] == null))
            {
                if (Session["exam_track"].ToString() == eid)
                {
                    p1.Visible = false;
                    p2.Visible = true;
                    resultmsg.Text = "You exited Exam without saving";
                }
            }

            p1.Visible = false;
            
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Result where Student_id=@sid and Exam_id=@eid", cn);
            cmd.Parameters.AddWithValue("@sid",sid);
            cmd.Parameters.AddWithValue("@eid",Convert.ToInt16(eid));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                p2.Visible = true;
                resultmsg.Text = "You already Completed this exam";
                cn.Close();
            }
            else
            {
                cn.Close();
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("select *from Exam where [Exam-id]=@eid", cn);
                cmd1.Parameters.AddWithValue("@eid", Convert.ToInt16(eid));
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        p1.Visible = true;
                        ename.Text = dr1["Exam_name"].ToString();
                        tot_que.Text = dr1["Total_Marks"].ToString();
                        Req_mark.Text = dr1["Req_marks"].ToString();
                        time.Text = dr1["Time"].ToString();
                        start_date = DateTime.Parse(dr1["Start_date"].ToString());
                        end_date = DateTime.Parse(dr1["End_date"].ToString());
                    }
                }
                else
                {
                    resultmsg.Text = "There is no question";
                }
                
                int d=DateTime.Compare(start_date, DateTime.Today);          
                if (d > 0)
                {
                    resultmsg.Text = "Exam has not started yet.";
                    p1.Visible = false;
                    p2.Visible = true;
                }
                int d1 = DateTime.Compare(end_date, DateTime.Today);
               
                if (d1 < 0)
                {
                    resultmsg.Text = "Exam ended";
                    p1.Visible = false;
                    p2.Visible = true;
                }
            }
        }

        protected void Start_Click(object sender, EventArgs e)
        {
            Session["exam_record"] = eid;
            Response.Redirect("give_test.aspx?exam_id=" +eid);
        }
    }
}