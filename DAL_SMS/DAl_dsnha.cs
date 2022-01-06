using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAl_dsnha: DBConnection
    {
        public DataTable getNha()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Nhathue", con);
            DataTable daNha = new DataTable();
            da.Fill(daNha);
            daNha.Columns.Add("Ord");
            for (int i = 1; i <= daNha.Rows.Count; i++)
                daNha.Rows[i - 1]["Ord"] = i.ToString();
            return daNha;
        }
        public bool ThemNha(string manha, string loainha,string soluong, string diachi, string dientich, string gia)
        {
            string str = string.Format("insert  into Nhathue (Manha,Loainha,Soluong,Diachi,Dientich,Gia) values('{0}',N'{1}','{2}',N'{3}','{4}','{5}')", manha,loainha,soluong,diachi,dientich,gia);
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
        public bool XoaNha(string manha)
        {
            string str = string.Format("delete  from Nhathue where Manha='{0}'", manha);
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
        public bool Sua(string manha,string manha1, string loainha, string soluong, string diachi, string dientich, string gia)
        {
            string str = string.Format("update Nhathue set Manha='{0}',Loainha=N'{1}',Soluong='{2}',Diachi=N'{3}',Dientich='{4}',Gia='{5}' where Manha ='{6}'", manha1, loainha, soluong, diachi, dientich, gia, manha);
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
    }
}
