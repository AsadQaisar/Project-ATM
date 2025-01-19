using Project_ATM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ATM
{
    public static class Global_Variables
    {
        // For Weighings rights
        public static int LoginID { get; set; }
        public static string UserLogin {get; set;}

        public static int RoleID { get; set; }
        public static tbl_User User { get; set; }
       
        public static bool Server_Connection { get; set; }
        public static bool Check_DB { get; set; }

    }
} 
