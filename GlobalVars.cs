using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект
{
    class GlobalVars
    {
        public static string globalip { get; set; }

        public static string dbconnect()
        //DB connection string
        {
            string serverName = "192.168.43.175", userName = "lalraen", dbName = "dekanat", port = "3306", passwordtobd = "3041996";
            string connStr = "server=" + serverName + ";user=" + userName + ";database=" + dbName + ";charset=utf8" + "; port=" + port + ";password=" + passwordtobd + ";";
            return connStr;
        }
        public static string GlobalUser { get; set; }
        public static string NotException { get; set; }
        public static string globalusergroup { get; set; }
        public static bool secondauth { get; set; }
        public static string documentpath { get; set; }

        public static bool intchecked { get; set; }
    }
}
