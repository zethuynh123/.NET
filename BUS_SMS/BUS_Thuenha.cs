using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;

namespace BUS_SMS
{
    public class BUS_Thuenha
    {
        DAL_Thuenha daThuenha = new DAL_Thuenha();
        public DataTable getNha()
        {
            return daThuenha.getNha();
        }
        public DataTable getNha(string manha)
        {
            return daThuenha.getNha(manha);
        }
            public DataTable TimLoaiNha(string loainha)
        {
            return daThuenha.TimLoaiNha(loainha);
        }
        public DataTable TimDiaChi(string diachi)
        {
            return daThuenha.TimDiaChi(diachi);
        }
        public bool ThueNha(int soluong, string manha)
        {
            return daThuenha.ThueNha(soluong, manha);
        }
        public bool InHoaDon(string manha, string loainha, string soluong, string diachi, string ngaymua, string gia, string dientich,string thanhtien)
        {
            return daThuenha.InHoaDon(manha, loainha, soluong, diachi, ngaymua, gia, dientich, thanhtien);
        }
    }
}
