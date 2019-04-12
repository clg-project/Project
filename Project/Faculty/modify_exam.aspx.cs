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
    public partial class modify_exam : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["exam_id"];
            if (!IsPostBack)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select *from Exam where [Exam-id]=@eid", cn);
                cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(s));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox1.Text = dr["Exam_name"].ToString();
                    TextBox2.Text = dr["Total_Marks"].ToString();
                    req_mrk.Text = dr["Req_marks"].ToString();
                    TextBox3.Text = dr["Time"].ToString();
                    DateTime dt = (DateTime)dr["Start_date"];
                    TextBox4.Text = dt.ToString("dd/MM/yyyy");
                    DateTime dt2 =(DateTime)dr["End_date"];
                    TextBox5.Text = dt2.ToString("dd/MM/yyyy");
                }
                else
                {
                    resultmsg.Text = "Something Went Wrong";
                }
                cn.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
                string s = Request.QueryString["exam_id"];
                cn.Open();
                SqlCommand cmd = new SqlCommand("update Exam set Exam_name=@ename,Total_Marks=@marks,Req_marks=@reqmar,Time=@time,Start_date=@start,End_date=@end where [Exam-id]=@eid", cn);
                cmd.Parameters.AddWithValue("@ename", TextBox1.Text);
                cmd.Parameters.AddWithValue("@marks", TextBox2.Text);
                cmd.Parameters.AddWithValue("@reqmar", req_mrk.Text);
                cmd.Parameters.AddWithValue("@time", TextBox3.Text);
           
                DateTime dt=DateTime.ParseExact(TextBox4.Text, "dd/MM/yyyy",null);
                cmd.Parameters.AddWithValue("@start",dt);
                DateTime dt2 = DateTime.ParseExact(TextBox5.Text, "dd/MM/yyyy", null);
                cmd.Parameters.AddWithValue("@end", dt2);
                cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(s));
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    resultmsg.Text = "Exam not Modified";
                }
                else
                {
                    Response.Redirect("Exam_list.aspx");
                    resultmsg.Text = "Exam modified";
                }
            }
           catch(Exception ex)
            {
               resultmsg.Text = "Something Went wrong" + ex.Message;
            }
        }
    }
}