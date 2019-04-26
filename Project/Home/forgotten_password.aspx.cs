using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Text;
using System.Data;

namespace Project
{
    public partial class forgotten_password : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (cn)
            {
                SqlCommand cmd = new SqlCommand("spResetPassword", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("@emailtype", TextBox1.Text);
                cmd.Parameters.Add(param);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToBoolean(dr["ReturnCode"]))
                    {
                        Mailtemp(dr["Email"].ToString(), dr["username"].ToString(), dr["UniqueId"].ToString());
                    }
                    else
                    {
                        Resultmsg.Text = "Username not found";
                    }
                }
            };

        }
        public void Mailtemp(string toemail, string Username, string Uniqueid)
        {

            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(TextBox1.Text.ToString());
                mail.From = new MailAddress("gabaniparth04@gmail.com");
                mail.Subject = "Password Recovery";

                StringBuilder sbEmailBody = new StringBuilder();
                sbEmailBody.Append("Dear " + Username + ",<br/><br/>");
                sbEmailBody.Append("Please click on the following link to reset your password");
                sbEmailBody.Append("<br/>"); sbEmailBody.Append("http://localhost:50141/Home/New_password.aspx?uid=" + Uniqueid);

                mail.IsBodyHtml = true;

                mail.Body = sbEmailBody.ToString();

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("gabaniparth04@gmail.com", "gabaniparth04");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Resultmsg.Text = "Mail sended successfully.";
            }
            catch
            {
                Resultmsg.Text = "something went wrong.plz check if you connect ot internet";
            }

        }
    }

}