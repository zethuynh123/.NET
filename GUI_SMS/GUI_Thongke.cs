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
    public partial class GUI_Thongke : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public GUI_Thongke()
        {
            InitializeComponent();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (radLoainha.Checked)
            {
                dgvThongke.DataSource = busThongKe.getHoaDonLN(txtLoainha.Text);
            }
            if (radNgaymua.Checked)
            {
                dgvThongke.DataSource = busThongKe.getHoaDonNM(txtNgaymua.Text);
            }
        }

        private void GUI_Thongke_Load(object sender, EventArgs e)
        {
            dgvThongke.DataSource = busThongKe.getHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewReportThongke f = new viewReportThongke();
            f.Show();
        }
    }
}
