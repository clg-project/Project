using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Collections;

namespace Project.Faculty
{
    public partial class send_mail : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            ArrayList list_emails = new ArrayList();
            string email;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Student where category_id=@cid",cn);
            cmd.Parameters.AddWithValue("@cid", d1.SelectedValue);
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
                resultmsg.Text = "No student";
                cn.Close();
            }

            foreach (string email_to in list_emails)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email_to);
                mail.From = new MailAddress("gabaniparth04@gmail.com");
                mail.Subject = "Password Recovery";
                mail.IsBodyHtml = true;
                mail.Body = "Hi";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("gabaniparth04@gmail.com", "gabaniparth04");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                resultmsg.Text = "Mail sended successfully.";
            }
        }
    }
}