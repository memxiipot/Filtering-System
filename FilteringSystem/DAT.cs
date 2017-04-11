using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FilteringSystem
{
    public class DATEnrollee
    {
        public static void AddRec(DataTable dtb)
        {
            
            string findID = "SELECT * FROM ENROLLEES WHERE StudentID = @id";
            string strcom = "SELECT * FROM STUDENTS WHERE StudentID = @id";
            string addEnrollee = "INSERT INTO ENROLLEES VALUES(@sytid, @studid, @degprogid, @yrlvlid)";
            SqlConnection con = new SqlConnection(GlobalData.strcon2);
            con.Open();
            int insert = 0;
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                int id = int.Parse(dtb.Rows[i]["StudentID"].ToString());
                SqlCommand com = new SqlCommand(strcom, con);
                com.Parameters.AddWithValue("@id", id);

                SqlCommand add = new SqlCommand(addEnrollee, con);

                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows == true)
                {
                    //add
                    dr.Close();
                    com = new SqlCommand(findID, con);
                    com.Parameters.AddWithValue("@id",id);
                    SqlDataReader d = com.ExecuteReader();
                    if(d.HasRows == false)
                    {
                        d.Close();
                        dr.Close();
                        
                        add.Parameters.AddWithValue("@sytid", dtb.Rows[i]["SchoolYearTermsID"].ToString());
                        add.Parameters.AddWithValue("@studid", dtb.Rows[i]["StudentID"].ToString());
                        add.Parameters.AddWithValue("@degprogid", dtb.Rows[i]["DegreeProgramID"].ToString());
                        //com.Parameters.AddWithValue("@yrlvlid", dtb.Rows[i]["YearLevelID"].ToString());
                        add.Parameters.AddWithValue("@yrlvlid", dtb.Rows[i]["YearLevelID"].ToString());
                        insert++;
                        d.Close();
                        dr.Close();

                        add.ExecuteNonQuery();
                    }
                    dr.Close();
                    d.Close();
                }
                dr.Close();
                dr.Close();
            }
            GlobalData.insertRec = insert;
            con.Close();

        }

        public static int DegreeSchool(string school, string degree)
        {
            string strcom = "SELECT * FROM SCHOOLNAMES WHERE Name = @school";
            string getSchId = "SELECT SchoolNameID FROM SCHOOLNAMES WHERE Name = @school";
            string addSch = "INSERT INTO SCHOOLNAMES VALUES (@school)";

            string chk = "SELECT * FROM DEGREEPROGRAMS WHERE DegreeProgramName = @name";
            string getDegId = "SELECT DegreeProgramID FROM DEGREEPROGRAMS WHERE DegreeProgramName = @name";
            string addDeg = "INSERT INTO DEGREEPROGRAMS VALUES (@name, @schid)";
            int schid = 0;
            int degSchID = 0;

            SqlConnection con = new SqlConnection(GlobalData.strcon2);
            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);
            com.Parameters.AddWithValue("@school", school);

            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows == true)
            {
                dr.Close();
                com = new SqlCommand(getSchId, con);
                com.Parameters.AddWithValue("@school", school);

                schid = (int)com.ExecuteScalar();
                dr.Close();
            }
            else //add school record
            {
                dr.Close();
                //add new record
                com = new SqlCommand(addSch,con);
                com.Parameters.AddWithValue("@school", school);
                com.ExecuteNonQuery();

                //get id from new record
                com = new SqlCommand(getSchId, con);
                com.Parameters.AddWithValue("@school", school);
                schid = (int)com.ExecuteScalar();
            }

            SqlCommand comm = new SqlCommand(chk, con);
            comm.Parameters.AddWithValue("@name", degree);

            SqlDataReader drr = comm.ExecuteReader();
            if (drr.HasRows == true) //degree school already existing. get id
            {
                drr.Close();
                comm = new SqlCommand(getDegId, con);
                comm.Parameters.AddWithValue("@name", degree);

                degSchID = (int)comm.ExecuteScalar();
                drr.Close();
            }
            else //no record yet. add new.
            {
                drr.Close();
                comm = new SqlCommand(addDeg, con);
                comm.Parameters.AddWithValue("@schid", schid);
                comm.Parameters.AddWithValue("@name", degree);
               
                comm.ExecuteNonQuery();


                //get id 
                comm = new SqlCommand(getDegId, con);
                comm.Parameters.AddWithValue("@name", degree);

                degSchID = (int)comm.ExecuteScalar();
                drr.Close();
            }

            con.Close();

            return degSchID;
        }


        public static int checkSyTerm(string sy, string term)
        {
            string strcom = "SELECT * FROM SCHOOLYEARTERMS WHERE SchoolYear = @sy AND Term = @term";
            string insert = "INSERT INTO SCHOOLYEARTERMS VALUES (@sy, @term)";
            string getid = "SELECT SchoolYearTermsID FROM SCHOOLYEARTERMS WHERE SchoolYear = @sy AND Term = @term";

            int id = 0;

            SqlConnection con = new SqlConnection(GlobalData.strcon2);
            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);
            com.Parameters.AddWithValue("@sy", sy);
            com.Parameters.AddWithValue("@term", term);

            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows == true)
            {
                //get id of record
                dr.Close();
                com = new SqlCommand(getid, con);
                com.Parameters.AddWithValue("@sy", sy);
                com.Parameters.AddWithValue("@term", term);

                id = (int)com.ExecuteScalar();
                dr.Close();
            }
            else
            {
                //insert record
                dr.Close();
                com = new SqlCommand(insert, con);
                com.Parameters.AddWithValue("@sy", sy);
                com.Parameters.AddWithValue("@term", term);
                com.ExecuteNonQuery();

                //get id of newly inserted record
                com = new SqlCommand(getid, con);
                com.Parameters.AddWithValue("@sy", sy);
                com.Parameters.AddWithValue("@term", term);

                id = (int)com.ExecuteScalar();
                dr.Close();
            }
            con.Close();
            return id;
        }
    }



    public class DAT
    {

        public static int checkid(int ID)
        {
            int i;
            string forid = "SELECT * FROM STUDENTS WHERE StudentID LIKE '%@id'";
            SqlConnection con = new SqlConnection(GlobalData.strcon2);
            con.Open();
            SqlCommand forID = new SqlCommand(forid, con);
            forID.Parameters.AddWithValue("@id", ID);

            SqlDataReader dr = forID.ExecuteReader();

            if (dr.HasRows == true)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            con.Close();
            int y = i;
            return i;
        }

        public static void Add(DataTable dtb)
        {
            string forid = "SELECT * FROM STUDENTS WHERE StudentID = @id";
            string strcom = "INSERT INTO STUDENTS VALUES (@id, @fname, @mname, @lname, @cstat, @hsid, @sex, @scholarshipID, @relID, @ethID, @address, @cityID)";
            SqlConnection con = new SqlConnection(GlobalData.strcon2);
            con.Open();
            int x = 0;
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                SqlCommand com = new SqlCommand(strcom, con);
                SqlCommand forID = new SqlCommand(forid, con);
                int id = int.Parse(dtb.Rows[i]["Idno"].ToString());

                forID.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = forID.ExecuteReader();
                Boolean h = dr.HasRows;
                if (dr.HasRows == false) //no record. add new;
                {
                    x++;
                    com.Parameters.AddWithValue("@id", dtb.Rows[i]["Idno"].ToString());
                    com.Parameters.AddWithValue("@fname", dtb.Rows[i]["Fname"].ToString());
                    com.Parameters.AddWithValue("@mname", dtb.Rows[i]["Mname"].ToString());
                    com.Parameters.AddWithValue("@lname", dtb.Rows[i]["Lname"].ToString());
                    com.Parameters.AddWithValue("@cstat", dtb.Rows[i]["Studtypein"].ToString());
                    com.Parameters.AddWithValue("@hsid", dtb.Rows[i]["HighSchoolID"].ToString());
                    com.Parameters.AddWithValue("@sex", dtb.Rows[i]["Sex"].ToString());
                    com.Parameters.AddWithValue("@scholarshipID", dtb.Rows[i]["ScholarshipID"].ToString());
                    com.Parameters.AddWithValue("@relID", dtb.Rows[i]["Religion"].ToString());
                    com.Parameters.AddWithValue("@ethID", dtb.Rows[i]["Ethnicity"].ToString());
                    com.Parameters.AddWithValue("@address", dtb.Rows[i]["Nostreet"].ToString());
                    com.Parameters.AddWithValue("@cityID", dtb.Rows[i]["CityProv"].ToString());
                    dr.Close();
                    com.ExecuteNonQuery();
                }
                else
                {
                    //do nothing
                }
                dr.Close();
                
            }
            GlobalData.insertRec = x;
            con.Close();
        }
        public static int CheckCity(string city, string prov)
        {
            int id = 0;
            int provid = 0;
            string strcom = "SELECT ProvinceID FROM PROVINCES WHERE ProvinceName = @prov";
            string strcom2 = "INSERT INTO PROVINCES VALUES (@prov)";
            string strcom3 = "INSERT INTO CITIES VALUES (@city, @prov)";
            string strcom4 = "SELECT * FROM PROVINCES WHERE ProvinceName = @prov";
            string strcom5 = "SELECT * FROM CITIES WHERE CityName = @city";
            string strcom6 = "SELECT CityID FROM CITIES WHERE CityName = @city";

            SqlConnection con1 = new SqlConnection(GlobalData.strcon2);
            con1.Open();

            SqlCommand com = new SqlCommand(strcom4, con1);
            com.Parameters.AddWithValue("@prov", prov);

            SqlDataReader dr1 = com.ExecuteReader();

            if (dr1.HasRows == false) //if province doesnt exist add one
            {
                dr1.Close();
                com = new SqlCommand(strcom2, con1);
                com.Parameters.AddWithValue("@prov", prov);
                com.ExecuteNonQuery();
                //get id of newly added province
                com = new SqlCommand(strcom, con1);
                com.Parameters.AddWithValue("@prov", prov);
                provid = (int)com.ExecuteScalar();
                dr1.Close();
            }
            else //province exist get provinceid
            {
                dr1.Close();
                com = new SqlCommand(strcom, con1);
                com.Parameters.AddWithValue("@prov", prov);
                provid = (int)com.ExecuteScalar();
                dr1.Close();
            }
            SqlConnection conn = new SqlConnection(GlobalData.strcon2);
            conn.Open();
            SqlCommand comm = new SqlCommand(strcom5, conn);
            comm.Parameters.AddWithValue("@city", city);

            SqlDataReader drr = comm.ExecuteReader();

            if (drr.HasRows == false) //No Cities yet. Add City
            {
                drr.Close();
                comm = new SqlCommand(strcom3, conn);
                comm.Parameters.AddWithValue("@city", city);
                comm.Parameters.AddWithValue("@prov", provid);
                comm.ExecuteNonQuery();

                comm = new SqlCommand(strcom6, conn);
                comm.Parameters.AddWithValue("@city", city);
                id = (int)comm.ExecuteScalar();
                drr.Close();
            }
            else //city is already present
            {
                drr.Close();
                comm = new SqlCommand(strcom6, conn);
                comm.Parameters.AddWithValue("@city", city);
                id = (int)comm.ExecuteScalar();
                drr.Close();
            }
            conn.Close();
            drr.Close();
            con1.Close();
            return id;
        }

 

        public static int CheckEthnicity(string eth)
        {
            int id = 0;
            string strcom = "SELECT * FROM ETHNICITIES WHERE EthnicityName = @eth";
            string strcom2 = "SELECT EthnicityID FROM ETHNICITIES WHERE EthnicityName = @eth";
            string strcom3 = "INSERT INTO ETHNICITIES VALUES (@eth)";
            SqlConnection con2 = new SqlConnection(GlobalData.strcon2);
            con2.Open();

            SqlCommand com = new SqlCommand(strcom, con2);
            com.Parameters.AddWithValue("@eth", eth);

            SqlDataReader drr = com.ExecuteReader();

            if (drr.HasRows == true)
            {
                drr.Close();
                SqlCommand comm = new SqlCommand(strcom2, con2);
                comm.Parameters.AddWithValue("@eth", eth);
                id = (int)comm.ExecuteScalar();
                comm.Dispose();
                drr.Close();
            }
            else
            {
                drr.Close();
                SqlCommand scm = new SqlCommand(strcom3, con2);
                scm.Parameters.AddWithValue("@eth", eth);
                scm.ExecuteNonQuery();
                scm.Dispose();

                drr.Close();
                SqlCommand scmm = new SqlCommand(strcom2, con2);
                scmm.Parameters.AddWithValue("@eth", eth);
                id = (int)scmm.ExecuteScalar();
                scmm.Dispose();
            }
            drr.Close();
            con2.Close();
            return id;
        }


        public static int CheckReligion(string religion)
        {
            int id = 0;
            string strcom = "SELECT * FROM RELIGIONS WHERE ReligionName = @religion";
            string strcom2 = "SELECT ReligionID FROM RELIGIONS WHERE ReligionName = @religion";
            string strcom3 = "INSERT INTO RELIGIONS VALUES (@religion)";
            SqlConnection con3 = new SqlConnection(GlobalData.strcon2);
            con3.Open();

            SqlCommand com = new SqlCommand(strcom, con3);
            com.Parameters.AddWithValue("@religion", religion);

            SqlDataReader dr3 = com.ExecuteReader();

            if (dr3.HasRows == true)
            {
                dr3.Close();
                com = new SqlCommand(strcom2, con3);
                com.Parameters.AddWithValue("@religion", religion);
                id = (int)com.ExecuteScalar();
                dr3.Close();
            }
            else
            {
                dr3.Close();
                com = new SqlCommand(strcom3, con3);
                com.Parameters.AddWithValue("@religion", religion);
                com.ExecuteNonQuery();
                com = new SqlCommand(strcom2, con3);
                com.Parameters.AddWithValue("@religion", religion);
                id = (int)com.ExecuteScalar();
                dr3.Close();
            }
            con3.Close();
            dr3.Close();
            return id;
        }



        public static int CheckCStatus(string status)
        {
            int id = 0;
            string strcom = "SELECT * FROM CURRENTSTATUS WHERE CurrentStatus = @stat";
            string strcom2 = "SELECT CurrentStatusID FROM CURRENTSTATUS WHERE CurrentStatus = @stat";
            string strcom3 = "INSERT INTO CURRENTSTATUS VALUES (@stat)";
            SqlConnection con4 = new SqlConnection(GlobalData.strcon2);
            con4.Open();

            SqlCommand com = new SqlCommand(strcom, con4);
            com.Parameters.AddWithValue("@stat", status);

            SqlDataReader dr4 = com.ExecuteReader();

            if (dr4.HasRows == true)
            {
                dr4.Close();
                com = new SqlCommand(strcom2, con4);
                com.Parameters.AddWithValue("@stat", status);
                id = (int)com.ExecuteScalar();
                dr4.Close();
            }
            else
            {
                dr4.Close();
                com = new SqlCommand(strcom3, con4);
                com.Parameters.AddWithValue("@stat", status);
                com.ExecuteNonQuery();

                com = new SqlCommand(strcom2, con4);
                com.Parameters.AddWithValue("@stat", status);
                id = (int)com.ExecuteScalar();
                dr4.Close();
            }
            con4.Close();

            dr4.Close();
            return id;
        }


        public static void AddStudBatch(DataTable dtb)
        {
            string strcom = "INSERT INTO Student VALUES(@Batch, @Idno, @Fname, @Lname, @Mname, @Citizenship, @Gender, @Birthdate, @Religion, @Studtypein, @Syin, @Termin, @Studtypeout, @Syout, @Termout, @Nostreet, @CityProv, @Region, @Zipcode, @Telno, @Degree, @School)";
            SqlConnection con = new SqlConnection(GlobalData.strcon);
            con.Open();

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                SqlCommand com = new SqlCommand(strcom, con);
                com.Parameters.AddWithValue("@Batch", dtb.Rows[i]["Batch"].ToString());
                com.Parameters.AddWithValue("@Idno", dtb.Rows[i]["Idno"].ToString());
                com.Parameters.AddWithValue("@Fname", dtb.Rows[i]["Fname"].ToString());
                com.Parameters.AddWithValue("@Lname", dtb.Rows[i]["Lname"].ToString());
                com.Parameters.AddWithValue("@Mname", dtb.Rows[i]["Mname"].ToString());
                com.Parameters.AddWithValue("@Citizenship", dtb.Rows[i]["Citizenship"].ToString());
                com.Parameters.AddWithValue("@Gender",dtb.Rows[i]["Gender"].ToString());
                com.Parameters.AddWithValue("@Birthdate",dtb.Rows[i]["Birthdate"].ToString());
                com.Parameters.AddWithValue("@Religion",dtb.Rows[i]["Religion"].ToString());
                com.Parameters.AddWithValue("@Studtypein",dtb.Rows[i]["Studtypein"].ToString());
                com.Parameters.AddWithValue("@Syin",dtb.Rows[i]["Syin"].ToString());
                com.Parameters.AddWithValue("@Termin",dtb.Rows[i]["Termin"].ToString());
                com.Parameters.AddWithValue("@Studtypeout",dtb.Rows[i]["Studtypeout"].ToString());
                com.Parameters.AddWithValue("@Syout",dtb.Rows[i]["Syout"].ToString());
                com.Parameters.AddWithValue("@Termout",dtb.Rows[i]["Termout"].ToString());
                com.Parameters.AddWithValue("@Nostreet",dtb.Rows[i]["Nostreet"].ToString());
                com.Parameters.AddWithValue("@CityProv",dtb.Rows[i]["CityProv"].ToString());
                com.Parameters.AddWithValue("@Region",dtb.Rows[i]["Region"].ToString());
                com.Parameters.AddWithValue("@Zipcode",dtb.Rows[i]["Zipcode"].ToString());
                com.Parameters.AddWithValue("@Telno",dtb.Rows[i]["Telno"].ToString());
                com.Parameters.AddWithValue("@Degree",dtb.Rows[i]["Degree"].ToString());
                com.Parameters.AddWithValue("@School", dtb.Rows[i]["School"].ToString());

                com.ExecuteNonQuery();
            }
            con.Close();
        }

    }
}