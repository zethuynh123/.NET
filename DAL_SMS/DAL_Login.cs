using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_SMS
{
    public class DAL_Login : DBConnection
    {
        public int getLogin(string username, string password)
        {
            SqlDataAdapter data = new SqlDataAdapter($"select * from [User] where username='{username}' and password='{password}'", con);//thuc hien cau lenh sql
            DataTable daLG = new DataTable();
            data.Fill(daLG);
            if (daLG.Rows.Count > 0)
            {
                return 1;
            }
            else return 0;

        } 
    }
}
