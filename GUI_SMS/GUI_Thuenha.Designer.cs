
namespace GUI_SMS
{
    partial class GUI_Thuenha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLoaisach = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radLoaisach = new System.Windows.Forms.RadioButton();
            this.radDiachi = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoainhamua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoluongmua = new System.Windows.Forms.TextBox();
            this.txtManhamua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiamua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaymua = new System.Windows.Forms.DateTimePicker();
            this.btnThue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDientich = new System.Windows.Forms.TextBox();
            this.txtDiachimua = new System.Windows.Forms.TextBox();
            this.dgvThue = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTimkiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoaisach
            // 
            this.txtLoaisach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaisach.Location = new System.Drawing.Point(135, 37);
            this.txtLoaisach.Name = "txtLoaisach";
            this.txtLoaisach.Size = new System.Drawing.Size(129, 22);
            this.txtLoaisach.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachi.Location = new System.Drawing.Point(135, 81);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(129, 22);
            this.txtDiachi.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.Location = new System.Drawing.Point(155, 139);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 33);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radLoaisach
            // 
            this.radLoaisach.AutoSize = true;
            this.radLoaisach.Checked = true;
            this.radLoaisach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radLoaisach.Location = new System.Drawing.Point(21, 38);
            this.radLoaisach.Name = "radLoaisach";
            this.radLoaisach.Size = new System.Drawing.Size(77, 19);
            this.radLoaisach.TabIndex = 4;
            this.radLoaisach.TabStop = true;
            this.radLoaisach.Text = "Loại nhà :";
            this.radLoaisach.UseVisualStyleBackColor = true;
            this.radLoaisach.CheckedChanged += new System.EventHandler(this.radLoaisach_CheckedChanged);
            // 
            // radDiachi
            // 
            this.radDiachi.AutoSize = true;
            this.radDiachi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radDiachi.Location = new System.Drawing.Point(21, 84);
            this.radDiachi.Name = "radDiachi";
            this.radDiachi.Size = new System.Drawing.Size(68, 19);
            this.radDiachi.TabIndex = 4;
            this.radDiachi.Text = "Địa chỉ :";
            this.radDiachi.UseVisualStyleBackColor = true;
            this.radDiachi.CheckedChanged += new System.EventHandler(this.radDiachi_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDiachi);
            this.panel1.Controls.Add(this.radLoaisach);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.txtLoaisach);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 238);
            this.panel1.TabIndex = 0;
            // 
            // txtLoainhamua
            // 
            this.txtLoainhamua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoainhamua.Location = new System.Drawing.Point(100, 12);
            this.txtLoainhamua.Name = "txtLoainhamua";
            this.txtLoainhamua.Size = new System.Drawing.Size(129, 22);
            this.txtLoainhamua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại nhà :";
            // 
            // txtSoluongmua
            // 
            this.txtSoluongmua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoluongmua.Location = new System.Drawing.Point(100, 65);
            this.txtSoluongmua.Name = "txtSoluongmua";
            this.txtSoluongmua.Size = new System.Drawing.Size(129, 22);
            this.txtSoluongmua.TabIndex = 1;
            // 
            // txtManhamua
            // 
            this.txtManhamua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtManhamua.Location = new System.Drawing.Point(100, 115);
            this.txtManhamua.Name = "txtManhamua";
            this.txtManhamua.Size = new System.Drawing.Size(129, 22);
            this.txtManhamua.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(35, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhà :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(347, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày mua :";
            // 
            // txtGiamua
            // 
            this.txtGiamua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiamua.Location = new System.Drawing.Point(430, 12);
            this.txtGiamua.Name = "txtGiamua";
            this.txtGiamua.Size = new System.Drawing.Size(129, 22);
            this.txtGiamua.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(347, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá :";
            // 
            // dtpNgaymua
            // 
            this.dtpNgaymua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaymua.Location = new System.Drawing.Point(430, 62);
            this.dtpNgaymua.Name = "dtpNgaymua";
            this.dtpNgaymua.Size = new System.Drawing.Size(129, 22);
            this.dtpNgaymua.TabIndex = 2;
            // 
            // btnThue
            // 
            this.btnThue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThue.Location = new System.Drawing.Point(263, 191);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(75, 33);
            this.btnThue.TabIndex = 3;
            this.btnThue.Text = "Thuê";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThue);
            this.panel2.Controls.Add(this.dtpNgaymua);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtGiamua);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDientich);
            this.panel2.Controls.Add(this.txtDiachimua);
            this.panel2.Controls.Add(this.txtManhamua);
            this.panel2.Controls.Add(this.txtSoluongmua);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLoainhamua);
            this.panel2.Location = new System.Drawing.Point(366, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 238);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(35, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Diện tích :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(350, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ :";
            // 
            // txtDientich
            // 
            this.txtDientich.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDientich.Location = new System.Drawing.Point(102, 174);
            this.txtDientich.Name = "txtDientich";
            this.txtDientich.Size = new System.Drawing.Size(129, 22);
            this.txtDientich.TabIndex = 1;
            // 
            // txtDiachimua
            // 
            this.txtDiachimua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachimua.Location = new System.Drawing.Point(430, 115);
            this.txtDiachimua.Name = "txtDiachimua";
            this.txtDiachimua.Size = new System.Drawing.Size(129, 22);
            this.txtDiachimua.TabIndex = 1;
            // 
            // dgvThue
            // 
            this.dgvThue.BackgroundColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column13,
            this.Column9,
            this.Column8,
            this.Column14});
            this.dgvThue.Location = new System.Drawing.Point(366, 270);
            this.dgvThue.Name = "dgvThue";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThue.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvThue.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvThue.Size = new System.Drawing.Size(587, 222);
            this.dgvThue.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Manha";
            this.Column4.FillWeight = 304.5685F;
            this.Column4.HeaderText = "Mã Nhà";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Loainha";
            this.Column5.FillWeight = 47.7289F;
            this.Column5.HeaderText = "Loại Nhà";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Soluong";
            this.Column6.FillWeight = 47.7289F;
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            this.Column6.Width = 93;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Diachi";
            this.Column7.FillWeight = 47.7289F;
            this.Column7.HeaderText = "Địa Chỉ";
            this.Column7.Name = "Column7";
            this.Column7.Width = 115;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Ngày Mua";
            this.Column13.Name = "Column13";
            this.Column13.Width = 130;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Gia";
            this.Column9.FillWeight = 104.5158F;
            this.Column9.HeaderText = "Giá";
            this.Column9.Name = "Column9";
            this.Column9.Width = 65;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Dientich";
            this.Column8.FillWeight = 47.7289F;
            this.Column8.HeaderText = "Diện Tích";
            this.Column8.Name = "Column8";
            this.Column8.Width = 90;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Thành tiền";
            this.Column14.Name = "Column14";
            // 
            // dgvTimkiem
            // 
            this.dgvTimkiem.BackgroundColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimkiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvTimkiem.Location = new System.Drawing.Point(12, 270);
            this.dgvTimkiem.Name = "dgvTimkiem";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimkiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTimkiem.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTimkiem.Size = new System.Drawing.Size(348, 222);
            this.dgvTimkiem.TabIndex = 3;
            this.dgvTimkiem.Click += new System.EventHandler(this.dgvTimkiem_Click);
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
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Diachi";
            this.Column10.HeaderText = "Địa Chỉ";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Dientich";
            this.Column11.HeaderText = "Diện Tích";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Gia";
            this.Column12.HeaderText = "Giá";
            this.Column12.Name = "Column12";
            // 
            // GUI_Thuenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(973, 504);
            this.Controls.Add(this.dgvTimkiem);
            this.Controls.Add(this.dgvThue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Thuenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Thuenha";
            this.Load += new System.EventHandler(this.GUI_Thuenha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoaisach;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radLoaisach;
        private System.Windows.Forms.RadioButton radDiachi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoainhamua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoluongmua;
        private System.Windows.Forms.TextBox txtManhamua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiamua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaymua;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThue;
        private System.Windows.Forms.DataGridView dgvTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDientich;
        private System.Windows.Forms.TextBox txtDiachimua;
    }
}