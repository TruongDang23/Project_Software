namespace ProjectTourism
{
    partial class FormQuanLyDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDanhGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnAVGRate = new System.Windows.Forms.Button();
            this.dgvQLDanhGia = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Find);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbMaTour);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnAVGRate);
            this.panel1.Controls.Add(this.dgvQLDanhGia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 437);
            this.panel1.TabIndex = 4;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Location = new System.Drawing.Point(757, 112);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(139, 46);
            this.btn_Find.TabIndex = 34;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(437, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Tour";
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(552, 118);
            this.cbbMaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(183, 36);
            this.cbbMaTour.TabIndex = 26;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuayLai.Location = new System.Drawing.Point(664, 380);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(232, 48);
            this.btnQuayLai.TabIndex = 25;
            this.btnQuayLai.Text = "Quay Lại Trang Chủ";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnAVGRate
            // 
            this.btnAVGRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnAVGRate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAVGRate.FlatAppearance.BorderSize = 0;
            this.btnAVGRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAVGRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAVGRate.Location = new System.Drawing.Point(443, 380);
            this.btnAVGRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAVGRate.Name = "btnAVGRate";
            this.btnAVGRate.Size = new System.Drawing.Size(213, 48);
            this.btnAVGRate.TabIndex = 24;
            this.btnAVGRate.Text = "Số Sao Trung Bình";
            this.btnAVGRate.UseVisualStyleBackColor = false;
            this.btnAVGRate.Click += new System.EventHandler(this.btnAVGRate_Click);
            // 
            // dgvQLDanhGia
            // 
            this.dgvQLDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLDanhGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQLDanhGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.dgvQLDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDanhGia.Location = new System.Drawing.Point(32, 160);
            this.dgvQLDanhGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQLDanhGia.Name = "dgvQLDanhGia";
            this.dgvQLDanhGia.RowHeadersWidth = 51;
            this.dgvQLDanhGia.Size = new System.Drawing.Size(864, 212);
            this.dgvQLDanhGia.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(332, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ ĐÁNH GIÁ";
            // 
            // FormQuanLyDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(936, 446);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanLyDanhGia";
            this.Text = "FormQuanLyDanhGia";
            this.Load += new System.EventHandler(this.FormQuanLyDanhGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQLDanhGia;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnQuayLai;
        public System.Windows.Forms.Button btnAVGRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Button btn_Find;
    }
}