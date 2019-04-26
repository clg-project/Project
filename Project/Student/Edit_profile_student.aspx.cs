using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Project
{
    public partial class Edit_profile_student : System.Web.UI.Page
    {
        string ses;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
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
            if (!IsPostBack)
            {
                getdata();
            }
        }
        public void getdata()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select *from Student where Student_id=@sid", cn);
            cmd.Parameters.AddWithValue("@sid", ses);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox2.Text = dr["F_name"].ToString();
                TextBox3.Text = dr["L_name"].ToString();
                TextBox4.Text = dr["Address"].ToString();
                TextBox5.Text = dr["City"].ToString();
                TextBox6.Text = dr["State"].ToString();
                TextBox7.Text = dr["Pin_code"].ToString();
                TextBox8.Text = dr["Country"].ToString();
                String s = dr["DOB"].ToString();
                DateTime dt = new DateTime();
                dt = DateTime.Parse(s);
                TextBox9.Text = dt.ToString("dd/MM/yyyy");
                TextBox10.Text = dr["Contact"].ToString();
                TextBox11.Text = dr["E-mail_id"].ToString();
                if (dr["Gender"].ToString() == "Male")
                {
                    RadioButtonList1.SelectedIndex = 0;
                }
                else
                {
                    RadioButtonList1.SelectedIndex = 1;
                }
            }
            cn.Close();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("update Student set F_name=@fname,L_name=@lname,Address=@add,City=@city,State=@state,Pin_code=@pin,Country=@country,DOB=@dob,Gender=@gender,Contact=@mno,[E-mail_id]=@email where Student_id=@sid", cn);
                cmd.Parameters.AddWithValue("@fname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@lname", TextBox3.Text);
                cmd.Parameters.AddWithValue("@add", TextBox4.Text);
                cmd.Parameters.AddWithValue("@city", TextBox5.Text);
                cmd.Parameters.AddWithValue("@state", TextBox6.Text);
                cmd.Parameters.AddWithValue("@pin", TextBox7.Text);
                cmd.Parameters.AddWithValue("@country", TextBox8.Text);
                string s = TextBox9.Text;

                DateTime dt = DateTime.ParseExact(s, "dd/MM/yyyy", null);
                cmd.Parameters.AddWithValue("@dob", dt);
                cmd.Parameters.AddWithValue("@gender", RadioButtonList1.SelectedValue);
                cmd.Parameters.AddWithValue("@mno", TextBox10.Text);
                cmd.Parameters.AddWithValue("@email", TextBox11.Text);
                cmd.Parameters.AddWithValue("@sid", ses);
                int i = cmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    resultmsg.Text = "There is some problem updating Profile" + s;
                }
                else
                {
                    resultmsg.Text = "Profile Updated Successfully";

                }
                cn.Close();
                ClearInputs(Page.Controls);
                RadioButtonList1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                resultmsg.Text = ex.Message;
            }

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            ClearInputs(Page.Controls);
            RadioButtonList1.SelectedIndex = -1;
        }
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearInputs(ctrl.Controls);
            }
        }
    }
}