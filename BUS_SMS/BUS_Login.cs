using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;

namespace BUS_SMS
{
   public class BUS_Login
    {
        DAL_Login daLG = new DAL_Login();
        public int getLG(string username, string password)
        {
            return daLG.getLogin(username, password);
        }
    }
}
