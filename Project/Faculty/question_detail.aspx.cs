using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Project.Faculty
{
    public partial class question_detail : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["qid"];
            if (!IsPostBack)
            {
                try
                {
                    using (cn)
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("select *from Question where Que_id=@qid", cn);
                        cmd.Parameters.AddWithValue("@qid", Convert.ToInt32(s));
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DetailsView1.DataSource = dt;
                        DetailsView1.DataBind();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            
        }

        protected void back_Click(object sender, EventArgs e)
        {
            string s1 = Request.QueryString["exam_id"];
            Response.Redirect("show_question.aspx?exam_id=" + s1);
        }
    }
}