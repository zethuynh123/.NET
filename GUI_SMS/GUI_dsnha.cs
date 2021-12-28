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
    public partial class GUI_dsnha : Form
    {
        BUS_dsnha busNha = new BUS_dsnha();
        bool tf, tf1;
        string manha;
        
        public GUI_dsnha()
        {
            InitializeComponent();
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
        }

        private void GUI_dsnha_Load(object sender, EventArgs e)
        {
            dgvNha.DataSource = busNha.getNha();
        }
        void lock_unlock(bool tf)
        {
           
            btnThem.Enabled = txtLoainha.Enabled = txtGia.Enabled = txtDiachi.Enabled = txtDientich.Enabled = txtManha.Enabled =txtSoluong.Enabled= !tf;
        }

        private void dgvNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNha_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                int i = dgvNha.CurrentRow.Index;
                manha=txtManha.Text = dgvNha[0, i].Value.ToString();
                txtLoainha.Text = dgvNha[1, i].Value.ToString();
                txtSoluong.Text = dgvNha[2, i].Value.ToString();
                txtDiachi.Text = dgvNha[3, i].Value.ToString();
                txtDientich.Text = dgvNha[4, i].Value.ToString();
                txtGia.Text = dgvNha[5, i].Value.ToString();
                
                tf1 = !tf1;
                lock_unlock1(tf1);
            }
            else MessageBox.Show("Inserting!\nClick Reset to do another thing.", "Information");
        }

        private void btmLammoi_Click(object sender, EventArgs e)
        {
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtManha.Text != "" && txtLoainha.Text != "" && txtSoluong.Text != "" && txtDiachi.Text != "" && txtDientich.Text != "" && txtGia.Text != "")
            {
                if (busNha.ThemNha(txtManha.Text, txtLoainha.Text,txtSoluong.Text, txtDiachi.Text, txtDientich.Text,txtGia.Text))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    tf = !tf;
                    lock_unlock(tf);
                    dgvNha.DataSource = busNha.getNha();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Điền thiếu thông tin!\nMời nhập lại.", "Thông báo");
                txtLoainha.Focus();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                lock_unlock(tf);
                txtManha.Text = txtLoainha.Text = txtDiachi.Text = txtDientich.Text = txtGia.Text = txtSoluong.Text= "";
                txtLoainha.Focus();
            }
            else MessageBox.Show("Updating or Deleting!\nClick Reset to do another thing.", "Information");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busNha.XoaNha(manha))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                tf1 = !tf1;
                lock_unlock1(tf1);
                dgvNha.DataSource = busNha.getNha();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtManha.Text != "" && txtLoainha.Text != "" && txtSoluong.Text != "" && txtDiachi.Text != "" && txtDientich.Text != "" && txtGia.Text != "")
            {
                if (busNha.Sua(manha,txtManha.Text, txtLoainha.Text, txtSoluong.Text, txtDiachi.Text, txtDientich.Text, txtGia.Text))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    tf1 = !tf1;
                    lock_unlock1(tf1);
                    dgvNha.DataSource = busNha.getNha();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("", "Thông báo");
            }
            tf1 = !tf1;
            lock_unlock1(tf1);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void lock_unlock1(bool tf1)
        {
            dgvNha.Enabled = tf1;
            btnSua.Enabled = btnXoa.Enabled = txtLoainha.Enabled = txtGia.Enabled=txtDiachi.Enabled=txtDientich.Enabled=txtManha.Enabled = txtSoluong.Enabled=!tf1;
        }
    }
}
