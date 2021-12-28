using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SMS
{
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            mnuLogout.Enabled = mnuManage.Enabled = mnuTacvu.Enabled  = !kt;
            mnuLogin.Enabled = mnuClose.Enabled = kt;

        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            GUI_Login f = new GUI_Login();
            f.Show();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_Menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }



        private void GUI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuManage_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_dsnha f = new GUI_dsnha();
            f.Show();
        }

        private void mnuThuenha_Click(object sender, EventArgs e)
        {
            GUI_Thuenha f = new GUI_Thuenha();
            f.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Thongke f = new GUI_Thongke();
            f.Show();
        }
    }
}
