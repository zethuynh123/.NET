using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_SMS
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection(@"server=DESKTOP-8BG2U68\DUYSQLSERVER; uid=sa; pwd=123; database= qliUser;");
        //public static SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - 8BG2U68\\DUYSQLSERVER;Initial Catalog = qliUser; User ID = sa; Password = 123");
       // Data Source = DESKTOP - 8BG2U68\DUYSQLSERVER;Initial Catalog = qliUser; User ID = sa
    }
}
