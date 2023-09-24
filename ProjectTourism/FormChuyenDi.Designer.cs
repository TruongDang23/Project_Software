namespace ProjectTourism
{
    partial class FormChuyenDi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenDi));
            this.btn_LienHe = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.dataGridView_DSChuyenDi = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Sao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_KhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_DiemDen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSChuyenDi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LienHe
            // 
            this.btn_LienHe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_LienHe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LienHe.ForeColor = System.Drawing.Color.White;
            this.btn_LienHe.Location = new System.Drawing.Point(1084, 360);
            this.btn_LienHe.Name = "btn_LienHe";
            this.btn_LienHe.Size = new System.Drawing.Size(118, 45);
            this.btn_LienHe.TabIndex = 57;
            this.btn_LienHe.Text = "Liên hệ";
            this.btn_LienHe.UseVisualStyleBackColor = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số sao";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá vé";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Người tham gia";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số ngày";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Khởi hành";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hành trình";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Tên
            // 
            this.Tên.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tên.HeaderText = "Tên";
            this.Tên.MinimumWidth = 6;
            this.Tên.Name = "Tên";
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.ForeColor = System.Drawing.Color.White;
            this.btn_ChiTiet.Location = new System.Drawing.Point(954, 360);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(118, 45);
            this.btn_ChiTiet.TabIndex = 56;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            // 
            // dataGridView_DSChuyenDi
            // 
            this.dataGridView_DSChuyenDi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_DSChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tên,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_DSChuyenDi.Location = new System.Drawing.Point(35, 183);
            this.dataGridView_DSChuyenDi.Name = "dataGridView_DSChuyenDi";
            this.dataGridView_DSChuyenDi.RowHeadersWidth = 51;
            this.dataGridView_DSChuyenDi.RowTemplate.Height = 24;
            this.dataGridView_DSChuyenDi.Size = new System.Drawing.Size(1167, 160);
            this.dataGridView_DSChuyenDi.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 31);
            this.label10.TabIndex = 54;
            this.label10.Text = "Danh sách chuyến đi";
            // 
            // tb_Sao
            // 
            this.tb_Sao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_Sao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sao.Location = new System.Drawing.Point(1100, 77);
            this.tb_Sao.Multiline = true;
            this.tb_Sao.Name = "tb_Sao";
            this.tb_Sao.Size = new System.Drawing.Size(65, 36);
            this.tb_Sao.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1014, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 36);
            this.label9.TabIndex = 51;
            this.label9.Text = "Số sao:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(778, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 36);
            this.label8.TabIndex = 48;
            this.label8.Text = "Giá:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_KhoiHanh
            // 
            this.dateTimePicker_KhoiHanh.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.dateTimePicker_KhoiHanh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_KhoiHanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_KhoiHanh.Location = new System.Drawing.Point(478, 77);
            this.dateTimePicker_KhoiHanh.Name = "dateTimePicker_KhoiHanh";
            this.dateTimePicker_KhoiHanh.Size = new System.Drawing.Size(293, 31);
            this.dateTimePicker_KhoiHanh.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(314, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 36);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ngày khởi hành:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_DiemDen
            // 
            this.tb_DiemDen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_DiemDen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiemDen.Location = new System.Drawing.Point(130, 72);
            this.tb_DiemDen.Multiline = true;
            this.tb_DiemDen.Name = "tb_DiemDen";
            this.tb_DiemDen.Size = new System.Drawing.Size(158, 36);
            this.tb_DiemDen.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 36);
            this.label11.TabIndex = 45;
            this.label11.Text = "Điểm đến:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(445, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(487, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chọn điểm đến tuyệt vời và phù hợp nhất với bạn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÃY TRẢI NGHIỆM VÀ KHÁM PHÁ VIỆT NAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bộ lọc";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btn_LienHe);
            this.panel2.Controls.Add(this.btn_ChiTiet);
            this.panel2.Controls.Add(this.dataGridView_DSChuyenDi);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tb_Sao);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_Gia);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker_KhoiHanh);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_DiemDen);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 417);
            this.panel2.TabIndex = 1;
            // 
            // tb_Gia
            // 
            this.tb_Gia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_Gia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gia.Location = new System.Drawing.Point(833, 75);
            this.tb_Gia.Multiline = true;
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(151, 36);
            this.tb_Gia.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 567);
            this.panel1.TabIndex = 12;
            // 
            // FormChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormChuyenDi";
            this.Text = "FormChuyenDi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSChuyenDi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.DataGridView dataGridView_DSChuyenDi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Sao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KhoiHanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_DiemDen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_Gia;
        private System.Windows.Forms.Panel panel1;
    }
}