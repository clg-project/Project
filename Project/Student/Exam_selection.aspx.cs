using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Project.Student
{
    public partial class Exam_selection : System.Web.UI.Page
    {
        string s;
        int cid;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                s = Session["student"].ToString();
            }

            if (IsPostBack == false)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select category_id from Student where Student_id=@sid", cn);
                cmd.Parameters.AddWithValue("@sid", s);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cid = Convert.ToInt32(dr["category_id"].ToString());
                }
                cn.Close();
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("select [Exam-id],Exam_name from Exam where Category_id=@cid", cn);
                cmd1.Parameters.AddWithValue("@cid", cid);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd1;
                DataSet ds = new DataSet();
                da.Fill(ds);
                DropDownList1.DataSource = ds;
                DropDownList1.DataBind();
                cn.Close();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select Time from Exam where [Exam-id]=@eid", cn);
            cmd.Parameters.AddWithValue("@eid", DropDownList1.SelectedValue);
            int i = Convert.ToInt16(cmd.ExecuteScalar());
            int totalseconds = i * 60;
            Session["time"] = totalseconds;
            Response.Redirect("Exam_detail.aspx?exam_id=" + DropDownList1.SelectedValue);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}