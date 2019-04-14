﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Project
{   
    public partial class give_test : System.Web.UI.Page
    {
        string ses;
        static int qid;
        string exam_id;
        static DataTable dt;
        static SqlDataAdapter da;
        static DataSet ds;
        static int rowindex;
        static int resultanswer;
        static int req_mark;
        int qn;
        int totalseconds = 0, seconds = 60, minutes = 60;
        static int tot_que;
        static string crt_ans ;
        SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                ses = Session["student"].ToString();
            }
            
            exam_id = Request.QueryString["exam_id"];    
            dt = new DataTable();                              
            string s5 = "select *from Question where Exam_id=@eid";
            cn.Open();
            SqlCommand cmd = new SqlCommand(s5, cn);
            cmd.Parameters.AddWithValue("@eid", exam_id);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds, "Question");
            dt = ds.Tables["Question"];
            tot_que = dt.Rows.Count;
            totque.Text = tot_que.ToString();
            cn.Close();
            if (IsPostBack == false)
            {
                qid = 0;
                rowindex = 0;
                resultanswer = 0;
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("select Req_marks from Exam where [Exam-id]=@eid", cn);
                cmd1.Parameters.AddWithValue("@eid",exam_id);
                req_mark =Convert.ToInt16(cmd1.ExecuteScalar());
                cn.Close();
                getdata2();
            }
        }
       
        public void getdata2()
        {
            if (rowindex < tot_que)
            {
                Que_test.Text = dt.Rows[rowindex]["Question"].ToString();
                option1.Text = dt.Rows[rowindex]["Option1"].ToString();
                option2.Text = dt.Rows[rowindex]["Option2"].ToString();
                option3.Text = dt.Rows[rowindex]["Option3"].ToString();
                option4.Text = dt.Rows[rowindex]["Option4"].ToString();
                qid = Convert.ToInt32(dt.Rows[rowindex]["Que_id"]);
                //Label3.Text = qid.ToString();
                
                qn = rowindex;
                qn++;
                qno.Text = qn.ToString();
            }
            else
            {
                upanel.Visible = false;
                if (req_mark <= resultanswer)
                {
                    result(resultanswer, "Pass");
                }
                else
                {
                    result(resultanswer, "Fail");
                }
                upanel.Visible = false;
            }
        }
        protected void next_Click(object sender, EventArgs e)
        {        
            rowindex++;                   
            getdata2();           
            getanswer();
        }
        protected void previous_Click(object sender, EventArgs e)
        {
            if (rowindex > 0)
            {
                rowindex--;
                getdata2();               
                getanswer();
            }
            else
            {
                string script = "alert(\"There is no previous Question.\")";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string ans = SelectedAnswer();
            if (ans == "nothing")
            {
                storeanswer("insert into tmpanswer values(@qid,'nothing',@sid)");
            }
            else
            {
                storeanswer("insert into tmpanswer values(@qid,'" + ans + "',@sid)");
            }
        }
        public void getanswer()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select Answer from tmpanswer where Que_id-@qid and Student_id=@sid",cn);
                cmd.Parameters.AddWithValue("@qid",qid);
                cmd.Parameters.AddWithValue("@sid", ses);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string ans = dr[0].ToString();
                        Label3.Text = ans.ToString();
                        setselected(ans);
                    }
                }
                else
                {
                    radiobuttonunchecked();
                }
                cn.Close();
                
            }
            catch(Exception ex)
            {
                Label3.Text = "Error"+ex.Message;
            }
        }
        public void storeanswer(string s)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(s, cn);
                cmd.Parameters.AddWithValue("@qid", qid);
                cmd.Parameters.AddWithValue("@sid", ses);
                cmd.ExecuteNonQuery();
                cn.Close();             
            }
            catch(Exception e)
            {
                Label3.Text = e.Message;
                
            }      
        }
        
        public void result(int marks,string resultstr)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Exam_name from Exam where [Exam-id]=@eid",cn);
            cmd.Parameters.AddWithValue("@eid", exam_id);
            String Exam_name = cmd.ExecuteScalar().ToString();
            cn.Close();
      
            try
            {               
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Result values(@stu_id,@exam_id,@ename,@result,@mark)", cn);
                cmd1.Parameters.AddWithValue("@stu_id",ses);
                cmd1.Parameters.AddWithValue("@exam_id", Convert.ToInt32(exam_id));
                cmd1.Parameters.AddWithValue("@ename",Exam_name);
                cmd1.Parameters.AddWithValue("@result", resultstr);
                cmd1.Parameters.AddWithValue("@mark", marks);
                
                int i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    Label3.Text = "Thank You for Completeing Exam";
                    
                }
                else
                {
                    Label3.Text = "Result is not inserted";
                }
            }
            catch(Exception ex)
            {
                Label3.Text = "Error: " + ex.Message;
            }
        }

        protected void Finish_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select *from tmpanswer where Student_id=@sid", cn);
                cmd.Parameters.AddWithValue("@sid", ses);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();

                cn.Open();
                SqlCommand cmd1 = new SqlCommand("select *from Question where Exam_id=@eid", cn);
                cmd1.Parameters.AddWithValue("@eid", exam_id);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cn.Close();

                for (int i = 0; i <= tot_que; i++)
                {
                    string s1 = dt.Rows[i]["Answer"].ToString();
                    string s2 = dt1.Rows[i]["Answer"].ToString();
                    if (s1 == s2)
                    {
                        resultanswer++;
                    }
                }
            }
            catch(Exception ex)
            {
                Label3.Text = ex.Message;
            }

            
            if (req_mark <= resultanswer)
            {
                result(resultanswer, "Pass");
            }
            else
            {
                result(resultanswer, "Fail");
            }
            upanel.Visible = false;
        } 

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Session["time"] = Convert.ToInt16(Session["time"]) - 1;
            if (Convert.ToInt16(Session["time"]) <= 0)
            {
                clock.Text = "Timeout!";
                Next.Visible = false;
            }
            else
            {
                totalseconds = Convert.ToInt16(Session["time"]);
                seconds = totalseconds % 60;
                minutes = totalseconds / 60;
                
                clock.Text = minutes + ":" + seconds;
            }
        }

        public void radiobuttonunchecked()
        {
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
        }
        public string SelectedAnswer()
        {
            if (RadioButton1.Checked == true)
            {
                return "A";
            }
            else if (RadioButton2.Checked == true)
            {
                return "B";
            }
            else if (RadioButton3.Checked == true)
            {
                return "C";
            }

            else if (RadioButton4.Checked == true)
            {
                return "D";
            }
            else
            {
                return "nothing";
            }
        }
        public void setselected(string ans)
        {
            if (ans == "A")
            {
                RadioButton1.Checked = true;
            }
            else if (ans == "B")
            {
                RadioButton2.Checked = true;
            }
            else if (ans == "C")
            {
                RadioButton3.Checked = true;
            }
            else if (ans == "D")
            {
                RadioButton4.Checked = true;
            }
        }
    }
}