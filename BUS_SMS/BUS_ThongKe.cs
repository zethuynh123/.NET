using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;

namespace BUS_SMS
{
    public class BUS_ThongKe
    {
        DAL_Thongke daThongke = new DAL_Thongke();
        public DataTable getHoaDon()
        {
            return daThongke.getHoaDon();
        }
        public DataTable getHoaDonLN(string loainha)
        {
            return daThongke.getHoaDonLN(loainha);
        }
        public DataTable getHoaDonNM(string ngaymua)
        {
            return daThongke.getHoaDonNM(ngaymua);
        }
    }
}

