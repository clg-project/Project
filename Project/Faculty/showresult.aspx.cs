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
    public partial class showresult : System.Web.UI.Page
    {
        string faculty;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["faculty"] == null)
            {
                Response.Redirect("~/Home/login.aspx");
            }
            else
            {
                faculty = Session["faculty"].ToString();
            }
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Exam where F_id=@fid",cn);
            cmd.Parameters.AddWithValue("@fid",faculty);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            cn.Close();
            Button2.Visible = false;

            if (!(Request.QueryString["exam_id"] == null))
            {
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("select Student_id,Result,Marks from Result where Exam_id=@eid", cn);
                cmd1.Parameters.AddWithValue("@eid", Request.QueryString["exam_id"]);
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds = new DataSet();
                da1.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                ViewState["DataTable"] = ds.Tables[0];
                cn.Close();
                if (!(ds.Tables[0].Rows.Count == 0))
                {
                    Button2.Visible = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {      
            Response.Redirect("showresult.aspx?exam_id=" + DropDownList1.SelectedValue);            
        }
        public void CreateExcelFile(DataTable Excel)
        {    
            Response.ClearContent();
            
            Response.AddHeader("content-disposition", string.Format("attachment; filename=Exam_Report.xls"));

            
            Response.ContentType = "application/vnd.ms-excel";
            string space = "";

            foreach (DataColumn dcolumn in Excel.Columns)
            {
                Response.Write(space + dcolumn.ColumnName);
                space = "\t";
            }
            Response.Write("\n");
            int countcolumn;
            foreach (DataRow dr in Excel.Rows)
            {
                space = "";
                for (countcolumn = 0; countcolumn < Excel.Columns.Count; countcolumn++)
                {

                    Response.Write(space + dr[countcolumn].ToString());
                    space = "\t";

                }

                Response.Write("\n");


            }
            Response.End();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["DataTable"];  
            CreateExcelFile(dt);
        }
    }
}