using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.Faculty
{
    public partial class Edit_category : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        string cid;
        protected void Page_Load(object sender, EventArgs e)
        {
            cid = Request.QueryString["cid"];
            if (!IsPostBack)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select *from category where Category_id=@cid", cn);
                cmd.Parameters.AddWithValue("@cid", cid);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textbox1.Text = dr["Category_name"].ToString();
                    }
                }
                cn.Close();
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update category set Category_name=@cname where Category_id=@cid", cn);
            cmd.Parameters.AddWithValue("@cname", textbox1.Text);
            cmd.Parameters.AddWithValue("@cid", cid);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                resultmsg.Text = "Record Successfully updated";
                Response.Redirect("category_list.aspx");
            }
            cn.Close();
        }
    }
}