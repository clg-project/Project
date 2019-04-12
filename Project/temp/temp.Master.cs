using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class temp1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BulletedList1.Items[0].Attributes.Add("class", "templibtn");
            BulletedList1.Items[1].Attributes.Add("class", "templibtn");
            BulletedList1.Items[2].Attributes.Add("class", "templibtn");
            BulletedList1.Items[3].Attributes.Add("class", "templibtn");
            

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            
        }
    }
}