using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Net.Mail;
using System.Text;
using System.Data;

namespace Project.Faculty
{
    public partial class add_Exam : System.Web.UI.Page
    {
        string Exam_id, Que_id, Que_number;
        int Que_id_increment = 0;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);

        protected void time_TextChanged(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select *from category", cn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dropdownlist1.DataSource = ds;
                dropdownlist1.DataBind();
            }
            CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                cn.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Exam values(@Exam_name,@Marks,@reqmarks,@time,@startdate,@enddate,@fid,@cid)", cn);
                cmd1.Parameters.AddWithValue("@Exam_name", Ename.Text);
                cmd1.Parameters.AddWithValue("@Marks", Convert.ToInt32(marks.Text));
                cmd1.Parameters.AddWithValue("@reqmarks", Convert.ToInt32(req_marks.Text));
                cmd1.Parameters.AddWithValue("@time", Convert.ToInt32(time.Text));
                cmd1.Parameters.AddWithValue("@startdate", start_date.Text);
                cmd1.Parameters.AddWithValue("@enddate", end_date.Text);
                cmd1.Parameters.AddWithValue("@fid", Session["faculty"].ToString());
                cmd1.Parameters.AddWithValue("@cid", dropdownlist1.SelectedValue);
                int i = cmd1.ExecuteNonQuery();
                if (i > 0)
                {
                    result.Text = "Exam added";
                    //p2.Visible = true;
                }
                else
                {
                    result.Text = "Something went wrong.please try again";
                }
            }
            catch (Exception ex)
            {
                result.Text = "Something went wrong. Subject is not added: " + ex.Message;
            }
            cn.Close();

            ArrayList list_emails = new ArrayList();
            string email;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Student where category_id=@cid", cn);
            cmd.Parameters.AddWithValue("@cid", dropdownlist1.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    email = dr["E-mail_id"].ToString();
                    list_emails.Add(email);
                }
                cn.Close();
            }
            else
            {
                result.Text = "No student";
                cn.Close();
            }

            foreach (string email_to in list_emails)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email_to);
                mail.From = new MailAddress("gabaniparth04@gmail.com");
                mail.Subject = "Exam Details";
                mail.IsBodyHtml = true;

                StringBuilder st = new StringBuilder();
                st.Append("<h1>Following are Exam detail: -</h1>");
                st.Append("<br><br>Exam name: " + Ename.Text);
                st.Append("<br>Exam Start Date: " + start_date.Text);
                st.Append("<br>Exam End Date: " + end_date.Text);
                st.Append("<br>Plz compelete Exam in above scheduled date");

                mail.Body = st.ToString();
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("gabaniparth04@gmail.com", "gabaniparth04");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                result.Text = "Mail sended successfully.";
            }
        }
    }
}