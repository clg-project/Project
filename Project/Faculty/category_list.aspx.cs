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
    public partial class category_list : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.Open();
            string s = "select *from category";
            SqlCommand cmd = new SqlCommand(s,cn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();   
            cn.Close();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "deletecat")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("delete from category where Category_id=@cid", cn);
                cmd.Parameters.AddWithValue("@cid",e.CommandArgument);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    resultmsg.Text = "We cannot delete this record";
                }
                cn.Close();

            }
        }
    }
}