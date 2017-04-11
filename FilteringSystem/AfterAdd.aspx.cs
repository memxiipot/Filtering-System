using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilteringSystem
{
    public partial class AfterAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = GlobalData.totalRec.ToString();
            Label5.Text = GlobalData.insertRec.ToString();

            if (GlobalData.insertRec == 0)
            {
                Label6.Text = "Records are already existing";
            }
            if ((GlobalData.insertRec < GlobalData.totalRec) && (GlobalData.insertRec != 0))
            {
                Label6.Text = "Other records were not inserted due to redundancy";
            }
            if (GlobalData.insertRec == GlobalData.totalRec)
            {
                Label6.Text = "All records added";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GlobalData.totalRec = 0;
            GlobalData.insertRec = 0;
            Response.Redirect("ViewWebServ.aspx");
        }
    }
}