using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace FilteringSystem
{
    public class GlobalData
    {
        //public static string strcon2 = "data source = .\\SQLEXPRESS; DATABASE=FilteringDatabase; Integrated Security=SSPI";
        public static string strcon2 = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
        public static string sKey = "3jnj1v3ndba9123bfrna4re";
        public static string bKey = "2k3nfbg23klwhd93bdj3vga";
        public static string ekey = "1iebasdj23nssdf9we23nfs";
        public static string strcon = "data source = .\\SQLEXPRESS; DATABASE=Filtering; Integrated Security=SSPI";

        public static int totalRec = 0;
        public static int insertRec = 0;
        public static string batch = "";
        public static string term = "";
        public static string sy = "";
    }
}