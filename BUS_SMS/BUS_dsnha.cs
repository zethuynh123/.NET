using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;
using System.Data.SqlClient;

namespace BUS_SMS
{
    public class BUS_dsnha
    {
        DAl_dsnha daNha = new DAl_dsnha();
        public DataTable getNha()
        {
            return daNha.getNha();
        }
        public bool ThemNha(string manha, string loainha, string soluong, string diachi, string dientich, string gia)
        {
            return daNha.ThemNha(manha, loainha, soluong, diachi, dientich, gia);
        }
        public bool XoaNha(string manha)
        {
            return daNha.XoaNha(manha);
        }
        public bool Sua(string manha, string manha1, string loainha, string soluong, string diachi, string dientich, string gia)
        {
            return daNha.Sua(manha, manha1, loainha, soluong, diachi, dientich, gia);
        }
    }
}
