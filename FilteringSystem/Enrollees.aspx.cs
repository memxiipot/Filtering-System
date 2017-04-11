using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FilteringSystem
{
    public partial class Enrollees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            filter.Service fil = new filter.Service();
            gv.DataSource = fil.GetStud(GlobalData.sKey, sy.Text, term.Text);
            gv.DataBind();
            BIZenrollee db = new BIZenrollee();
            Session.Clear();
            DataTable forward;

            if (Session["ToDB"] == null)
            {
                forward = new DataTable("ToDB");
                forward.Columns.Add("SchoolYearTermsID");
                forward.Columns.Add("StudentID");
                forward.Columns.Add("DegreeProgramID");
                forward.Columns.Add("YearLevelID");
            }
            else
            {
                forward = (DataTable)Session["ToDB"];
            }


            for (int i = 0; i < gv.Rows.Count; i++)
            {
                DataRow drwForward = forward.NewRow();
                string schyr = gv.Rows[i].Cells[1].Text;
                string Term = gv.Rows[i].Cells[2].Text;
                string degree = gv.Rows[i].Cells[3].Text;
                string school = gv.Rows[i].Cells[4].Text;
                int yrlvl = 1;
                int StudId = int.Parse(gv.Rows[i].Cells[0].Text);

                drwForward["SchoolYearTermsID"] = db.setSyTerm(schyr, Term);
                drwForward["StudentID"] = gv.Rows[i].Cells[0].Text;
                drwForward["DegreeProgramID"] = db.setDegree(school, degree);
                drwForward["YearLevelID"] = yrlvl;

                forward.Rows.Add(drwForward);
                GlobalData.totalRec = gv.Rows.Count;
            }


            Session.Add("ToDB", forward);
            gv.DataSource = forward;
            gv.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BIZenrollee addrec = new BIZenrollee();
            DataTable forward = (DataTable)Session["ToDB"];
            //drwForward["StudentID"] = gv.Rows[i].Cells[0].Text;
            addrec.Add(forward);
            Session.Clear();
            Response.Redirect("postEnrollees.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainInsertion.aspx");
        }
    }
}