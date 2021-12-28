using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_SMS
{
    public class  DAL_Thuenha : DBConnection
    {
        public DataTable getNha()
        {
            string str = string.Format("select * from Nhathue");
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public DataTable getNha(string manha)
        {
            string str = string.Format("select * from Nhathue where Manha='{0}'",manha);
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public DataTable TimLoaiNha(string loainha){

            string str = string.Format("select * from Nhathue where Loainha like N'{0}' ","%"+loainha+"%" );
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);        
            return Thuenha; 
         }
        public DataTable TimDiaChi(string diachi)
        {

            string str = string.Format("select * from Nhathue where Diachi like N'%{0}%'", diachi);
            SqlDataAdapter da = new SqlDataAdapter(str, con);//thuc hien sql
            DataTable Thuenha = new DataTable();
            da.Fill(Thuenha);
            return Thuenha;
        }
        public bool ThueNha(int soluong, string manha)
        {

            string str = string.Format("update Nhathue set Soluong='{0}' where Manha ='{1}'", soluong, manha);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;

        }
        public bool InHoaDon(string manha, string loainha, string soluong, string diachi, string ngaymua, string gia, string dientich,string thanhtien)
        {
            string str = string.Format("insert  into HoaDonn (Manha,Loainha,Soluong,Diachi,Ngaymua,Gia,Dientich,Thanhtien) values('{0}',N'{1}','{2}',N'{3}','{4}','{5}','{6}','{7}')", manha, loainha, soluong, diachi, ngaymua, gia, dientich, thanhtien);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
           
        }
    }
}
