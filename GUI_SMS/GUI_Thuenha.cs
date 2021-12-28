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
    public partial class GUI_Thuenha : Form
    {
        BUS_Thuenha busThuenha = new BUS_Thuenha();
        string manha;
        public GUI_Thuenha()
        {
            InitializeComponent();
        }

        private void GUI_Thuenha_Load(object sender, EventArgs e)
        {
            dgvTimkiem.DataSource = busThuenha.getNha();
            
        }
        private String sl;
        private void btnThue_Click(object sender, EventArgs e)
        {
            if(txtLoainhamua.Text !="" && txtGiamua.Text!="" && txtSoluongmua.Text != "" && txtManhamua.Text != "")
            {             
                manha = txtManhamua.Text;       
                int slm = Convert.ToInt32(txtSoluongmua.Text);
                int slk = Convert.ToInt32(sl);
                if ((slk - slm) >= 0)
                { 
                    dgvThue.Rows.Add(txtManhamua.Text, txtLoainhamua.Text, txtSoluongmua.Text, txtDiachimua.Text, dtpNgaymua.Value.ToString(), txtGiamua.Text, txtDientich.Text, (slm * Int32.Parse(txtGiamua.Text)).ToString());
                    busThuenha.ThueNha((slk - slm), manha);
                    dgvTimkiem.DataSource = busThuenha.getNha();
                    if (busThuenha.InHoaDon(txtManhamua.Text, txtLoainhamua.Text, txtSoluongmua.Text, txtDiachimua.Text, dtpNgaymua.Value.ToString(), txtGiamua.Text, txtDientich.Text, (slm * Int32.Parse(txtGiamua.Text)).ToString()))
                    {
                        MessageBox.Show("Lưu hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("In đéo dc");
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng nhà không đủ, chỉ còn " + sl);
                }
                       
            }
            else
            {
                MessageBox.Show("Thiếu thông tin","Thông báo");
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (radLoaisach.Checked)
            {
                
                dgvTimkiem.DataSource = busThuenha.TimLoaiNha(txtLoaisach.Text);
            }
            if (radDiachi.Checked)
            {
                
                dgvTimkiem.DataSource = busThuenha.TimDiaChi(txtDiachi.Text);
            }
        }
        private void dgvTimkiem_Click(object sender, EventArgs e)
        {
            int i = dgvTimkiem.CurrentRow.Index;
            manha = txtManhamua.Text = dgvTimkiem[0, i].Value.ToString();
            sl= dgvTimkiem[2, i].Value.ToString();
            txtLoainhamua.Text = dgvTimkiem[1, i].Value.ToString();
            txtDiachimua.Text = dgvTimkiem[3, i].Value.ToString();
            txtDientich.Text = dgvTimkiem[4, i].Value.ToString();         
            txtGiamua.Text = dgvTimkiem[5, i].Value.ToString();
            dgvThue.Rows.Clear();
        }

        private void radLoaisach_CheckedChanged(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
        }

        private void radDiachi_CheckedChanged(object sender, EventArgs e)
        {
            txtLoaisach.Text = "";
        }
    }
}
