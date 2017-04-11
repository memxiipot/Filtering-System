using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FilteringSystem
{
    public class BIZenrollee
    {
        private int syterms = 0;
        private int degreeID = 0;
        private int yrLvl = 1;

        public void Add(DataTable dtb)
        {
            DATEnrollee.AddRec(dtb);
        }

        public int setSyTerm(string sy, string term)
        {
            int id = 0;
            id = DATEnrollee.checkSyTerm(sy, term);
            this.syterms = id;
            return this.syterms;
        }

        public int setDegree(string school, string degree)
        {
            int id = 0;
            id = DATEnrollee.DegreeSchool(school, degree);
            this.degreeID = id;
            return this.degreeID;
        }

    }


    public class BIZ
    {
        private int cStatusID = 0;
        private int religionID = 0;
        private int cityID = 0;
        private int ethID = 0;
        private int studID;
        private string fname = "";
        private string mname = "";
        private string lname = "";
        private int hsID = 1;
        private string sex = "";
        private int scholarshipID = 1;
        private string strAddress = "";

        public int checkid(int id)
        {
            return DAT.checkid(id);
        }


        public void Add(DataTable dtb)
        {
            DAT.Add(dtb);
        }

        public int getethID(string eth)
        {
            int id = 0;
            id = DAT.CheckEthnicity(eth);
            this.ethID = id;
            return this.ethID;
        }
        public int getCity(string city, string prov)
        {
            int id = 0;
            id = DAT.CheckCity(city, prov);
            this.cityID = id;
            return this.cityID;
        }

        public int getcStatusID(string stat)
        {
            int id = 0;
            id =  DAT.CheckCStatus(stat);
            this.cStatusID = id;
            return this.cStatusID;
        }

        public int getRelID(string rel)
        {
            int id = 0;
            id = DAT.CheckReligion(rel);
            this.religionID = id;
            return this.religionID;
        }


        public void AddStudBatch(DataTable dtb)
        {
            DAT.AddStudBatch(dtb);
        }



    }
}