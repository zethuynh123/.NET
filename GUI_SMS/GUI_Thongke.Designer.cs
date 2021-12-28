
namespace GUI_SMS
{
    partial class GUI_Thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.txtNgaymua = new System.Windows.Forms.TextBox();
            this.txtLoainha = new System.Windows.Forms.TextBox();
            this.radNgaymua = new System.Windows.Forms.RadioButton();
            this.radLoainha = new System.Windows.Forms.RadioButton();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.txtNgaymua);
            this.panel1.Controls.Add(this.txtLoainha);
            this.panel1.Controls.Add(this.radNgaymua);
            this.panel1.Controls.Add(this.radLoainha);
            this.panel1.Location = new System.Drawing.Point(170, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 189);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "In Bảng Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongke.Location = new System.Drawing.Point(142, 122);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(75, 37);
            this.btnThongke.TabIndex = 3;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // txtNgaymua
            // 
            this.txtNgaymua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaymua.Location = new System.Drawing.Point(166, 70);
            this.txtNgaymua.Name = "txtNgaymua";
            this.txtNgaymua.Size = new System.Drawing.Size(150, 22);
            this.txtNgaymua.TabIndex = 1;
            // 
            // txtLoainha
            // 
            this.txtLoainha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoainha.Location = new System.Drawing.Point(166, 26);
            this.txtLoainha.Name = "txtLoainha";
            this.txtLoainha.Size = new System.Drawing.Size(150, 22);
            this.txtLoainha.TabIndex = 1;
            // 
            // radNgaymua
            // 
            this.radNgaymua.AutoSize = true;
            this.radNgaymua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNgaymua.Location = new System.Drawing.Point(81, 70);
            this.radNgaymua.Name = "radNgaymua";
            this.radNgaymua.Size = new System.Drawing.Size(85, 19);
            this.radNgaymua.TabIndex = 0;
            this.radNgaymua.Text = "Ngày mua :";
            this.radNgaymua.UseVisualStyleBackColor = true;
            // 
            // radLoainha
            // 
            this.radLoainha.AutoSize = true;
            this.radLoainha.Checked = true;
            this.radLoainha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radLoainha.Location = new System.Drawing.Point(81, 27);
            this.radLoainha.Name = "radLoainha";
            this.radLoainha.Size = new System.Drawing.Size(77, 19);
            this.radLoainha.TabIndex = 0;
            this.radLoainha.TabStop = true;
            this.radLoainha.Text = "Loại nhà :";
            this.radLoainha.UseVisualStyleBackColor = true;
            // 
            // dgvThongke
            // 
            this.dgvThongke.BackgroundColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column5});
            this.dgvThongke.Location = new System.Drawing.Point(24, 206);
            this.dgvThongke.Name = "dgvThongke";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongke.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvThongke.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongke.Size = new System.Drawing.Size(744, 232);
            this.dgvThongke.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Manha";
            this.Column1.HeaderText = "Mã Nhà";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Loainha";
            this.Column2.HeaderText = "Loại Nhà";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Soluong";
            this.Column3.HeaderText = "Sô Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Ngaymua";
            this.Column7.HeaderText = "Ngày Mua";
            this.Column7.Name = "Column7";
            this.Column7.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Dientich";
            this.Column5.HeaderText = "Diện Tích";
            this.Column5.Name = "Column5";
            // 
            // GUI_Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvThongke);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Thongke";
            this.Load += new System.EventHandler(this.GUI_Thongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.TextBox txtLoainha;
        private System.Windows.Forms.RadioButton radNgaymua;
        private System.Windows.Forms.RadioButton radLoainha;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.TextBox txtNgaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}