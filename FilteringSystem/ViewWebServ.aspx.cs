using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FilteringSystem
{
    public partial class ViewWebServ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            filter.Service fil = new filter.Service();
            Session.Clear();
            numRows.Text = "";
            Label2.Text = "";
            
            stud.DataSource = fil.GetBatch(GlobalData.bKey, tb1.Text);
            stud.DataBind();
            numRows.Text = stud.Rows.Count.ToString();

            //dtb values
            int cStatusID;
            int religionID;
            int cityID;
            int ethID;
            int studID = 0; ;
            string fname = "";
            string mname = "";
            string lname = "";
            int hsID = 1;
            string sex = "";
            int scholarshipID = 1;
            string strAddress = "";

            //filter.Service fil = new filter.Service();
            DataTable forward;
            BIZ db = new BIZ();
            Label2.Text = "";
            if (Session["ToDB"] == null)
            {
                forward = new DataTable("ToDB");
                // forward.Columns.Add("Batch");
                forward.Columns.Add("Idno");
                forward.Columns.Add("Fname");
                forward.Columns.Add("Mname");
                forward.Columns.Add("Lname");
                forward.Columns.Add("Studtypein");
                forward.Columns.Add("HighschoolID");
                forward.Columns.Add("Sex");
                forward.Columns.Add("ScholarshipID");
                forward.Columns.Add("Religion");
                forward.Columns.Add("Ethnicity");
                forward.Columns.Add("Nostreet");
                forward.Columns.Add("CityProv");

            }
            else
            {
                forward = (DataTable)Session["ToDB"];
            }

            for (int i = 0; i < stud.Rows.Count; i++)
            {
                int k = int.Parse(stud.Rows[i].Cells[1].Text);
                int p = db.checkid(int.Parse(stud.Rows[i].Cells[1].Text));
                DataRow drwForward = forward.NewRow();

                drwForward["Idno"] = stud.Rows[i].Cells[1].Text;
                studID = int.Parse(stud.Rows[i].Cells[1].Text);


                drwForward["Fname"] = stud.Rows[i].Cells[2].Text;
                fname = stud.Rows[i].Cells[2].Text;

                drwForward["Mname"] = stud.Rows[i].Cells[4].Text;
                mname = stud.Rows[i].Cells[4].Text;

                drwForward["Lname"] = stud.Rows[i].Cells[3].Text;
                lname = stud.Rows[i].Cells[3].Text;

                drwForward["Studtypein"] = db.getcStatusID(stud.Rows[i].Cells[9].Text);
                cStatusID = db.getcStatusID(stud.Rows[i].Cells[9].Text);

                drwForward["HighSchoolID"] = 1;
                hsID = 1;

                drwForward["Sex"] = stud.Rows[i].Cells[6].Text;
                sex = stud.Rows[i].Cells[6].Text;

                drwForward["ScholarshipID"] = 1;
                scholarshipID = 1;

                drwForward["Religion"] = db.getRelID(stud.Rows[i].Cells[8].Text.ToUpper());
                religionID = db.getRelID(stud.Rows[i].Cells[8].Text.ToUpper());

                drwForward["Ethnicity"] = db.getethID(stud.Rows[i].Cells[5].Text);
                ethID = db.getethID(stud.Rows[i].Cells[5].Text);

                drwForward["Nostreet"] = stud.Rows[i].Cells[15].Text;
                strAddress = stud.Rows[i].Cells[15].Text;

                drwForward["CityProv"] = db.getCity(stud.Rows[i].Cells[16].Text, stud.Rows[i].Cells[17].Text);
                cityID = db.getCity(stud.Rows[i].Cells[16].Text, stud.Rows[i].Cells[17].Text);

                forward.Rows.Add(drwForward);



            }

            Session.Add("ToDB", forward);


            stud.DataSource = forward;
            stud.DataBind();
            Label2.Text = forward.Rows.Count.ToString();
            GlobalData.totalRec = int.Parse(Label2.Text);
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    //dtb values
        //    int cStatusID;
        //    int religionID;
        //    int cityID;
        //    int ethID;
        //    int studID = 0; ;
        //    string fname = "";
        //    string mname = "";
        //    string lname = "";
        //    int hsID = 1;
        //    string sex = "";
        //    int scholarshipID = 1;
        //    string strAddress = "";

        //    filter.Service fil = new filter.Service();
        //    DataTable forward;
        //    BIZ db = new BIZ();
        //    Label2.Text = "";
        //    if (Session["ToDB"] == null)
        //    {
        //        forward = new DataTable("ToDB");
        //       // forward.Columns.Add("Batch");
        //        forward.Columns.Add("Idno");
        //        forward.Columns.Add("Fname");
        //        forward.Columns.Add("Mname");
        //        forward.Columns.Add("Lname");
        //        forward.Columns.Add("Studtypein");
        //        forward.Columns.Add("HighschoolID");
        //        forward.Columns.Add("Sex");
        //        forward.Columns.Add("ScholarshipID");
        //        forward.Columns.Add("Religion");
        //        forward.Columns.Add("Ethnicity");
        //        forward.Columns.Add("Nostreet");
        //        forward.Columns.Add("CityProv");
               
        //    }
        //    else
        //    {
        //        forward = (DataTable)Session["ToDB"];
        //    }

        //    for (int i = 0; i < stud.Rows.Count; i++)
        //    {
        //        int k = int.Parse(stud.Rows[i].Cells[1].Text);
        //        int p = db.checkid(int.Parse(stud.Rows[i].Cells[1].Text));
        //            DataRow drwForward = forward.NewRow();

        //            drwForward["Idno"] = stud.Rows[i].Cells[1].Text;
        //            studID = int.Parse(stud.Rows[i].Cells[1].Text);


        //            drwForward["Fname"] = stud.Rows[i].Cells[2].Text;
        //            fname = stud.Rows[i].Cells[2].Text;

        //            drwForward["Mname"] = stud.Rows[i].Cells[4].Text;
        //            mname = stud.Rows[i].Cells[4].Text;

        //            drwForward["Lname"] = stud.Rows[i].Cells[3].Text;
        //            lname = stud.Rows[i].Cells[3].Text;

        //            drwForward["Studtypein"] = db.getcStatusID(stud.Rows[i].Cells[9].Text);
        //            cStatusID = db.getcStatusID(stud.Rows[i].Cells[9].Text);

        //            drwForward["HighSchoolID"] = 1;
        //            hsID = 1;

        //            drwForward["Sex"] = stud.Rows[i].Cells[6].Text;
        //            sex = stud.Rows[i].Cells[6].Text;

        //            drwForward["ScholarshipID"] = 1;
        //            scholarshipID = 1;

        //            drwForward["Religion"] = db.getRelID(stud.Rows[i].Cells[8].Text.ToUpper());
        //            religionID = db.getRelID(stud.Rows[i].Cells[8].Text.ToUpper());

        //            drwForward["Ethnicity"] = db.getethID(stud.Rows[i].Cells[5].Text);
        //            ethID = db.getethID(stud.Rows[i].Cells[5].Text);

        //            drwForward["Nostreet"] = stud.Rows[i].Cells[15].Text;
        //            strAddress = stud.Rows[i].Cells[15].Text;

        //            drwForward["CityProv"] = db.getCity(stud.Rows[i].Cells[16].Text, stud.Rows[i].Cells[17].Text);
        //            cityID = db.getCity(stud.Rows[i].Cells[16].Text, stud.Rows[i].Cells[17].Text);

        //            forward.Rows.Add(drwForward);
          

                
        //    }

        //    Session.Add("ToDB", forward);

            
        //    stud.DataSource = forward;
        //    stud.DataBind();
        //    Label2.Text = forward.Rows.Count.ToString();
        //    GlobalData.totalRec = int.Parse(Label2.Text);
        //}

        protected void Button3_Click(object sender, EventArgs e)
        {
            GlobalData.batch = tb1.Text;
            BIZ plus = new BIZ();
            DataTable forward = (DataTable)Session["ToDB"];
            //Add.AddStudBatch(forward);
            plus.Add(forward);
            msg.Text = "Records from batch: " + tb1.Text + "has been added to the database";
            Session.Clear();
            Response.Redirect("AfterAdd.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainInsertion.aspx");
        }
    }
}