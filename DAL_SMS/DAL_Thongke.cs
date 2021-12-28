using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_Thongke : DBConnection
    {
        public DataTable getHoaDon()
        {
            string str = string.Format("select * from HoaDonn");
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public DataTable getHoaDonLN(string loainha)
        {
            string str = string.Format("select * from HoaDonn where LOWER(Loainha) like N'%{0}%'",loainha.ToLower());
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public DataTable getHoaDonNM(string ngaymua)
        {
            string str = string.Format("select * from HoaDonn where Ngaymua like '%{0}%'", ngaymua);
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
    }
}
