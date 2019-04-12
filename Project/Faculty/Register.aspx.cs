using System;
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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.Open();
            string sql = "select *from category";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
                string dob = string.Format("{0:dd/MM/yyyy}", TextBox9.Text);
                string s = "insert into Student values('" + TextBox1.Text + "','" + TextBox2.Text + "'," +
                    "'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," +
                    "'" + TextBox6.Text + "','" + Convert.ToInt32(TextBox7.Text) + "','" + TextBox8.Text + "','" + dob + "'," +
                    "'" + RadioButtonList1.SelectedValue + "','" + Convert.ToInt64(TextBox10.Text) + "'," +
                    "'" + TextBox11.Text + "','" + TextBox12.Text + "',@fid,@cid)";
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand(s, cn);
                cmd.Parameters.AddWithValue("@cid", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@fid", Session["faculty"].ToString());
                int i=cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    Result.Text = "Student doesn't registered";
                }
                cn.Close();
                Result.Text = "Student registered Successfully";
            }
            catch(SqlException ex)
            {
                Result.Text = "Data not inserted coorectly"+ex.Message;
            }
        }
    }
}