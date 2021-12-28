using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_SMS;

namespace GUI_SMS
{
    public partial class GUI_Login : Form
    {
        BUS_Login bn = new BUS_Login();
        public GUI_Login()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
        }



        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;


            int i = bn.getLG(username, password);
            if (txtPassword.Text != "" && txtUserName.Text != "")
            {
                if (i == 1)
                {
                    mySave.KT = !mySave.KT;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin, mời nhập lại", "Thông báo");
            }
        }
    }
}
