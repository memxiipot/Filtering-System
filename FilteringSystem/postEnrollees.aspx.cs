using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilteringSystem
{
    public partial class postEnrollees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = GlobalData.totalRec.ToString();
            Label5.Text = GlobalData.insertRec.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Enrollees.aspx");
        }
    }
}