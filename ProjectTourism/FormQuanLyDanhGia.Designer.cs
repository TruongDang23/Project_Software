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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnAVGRate = new System.Windows.Forms.Button();
            this.dgvQLDanhGia = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 355);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(328, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Tour";
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(414, 96);
            this.cbbMaTour.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(138, 29);
            this.cbbMaTour.TabIndex = 26;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuayLai.Location = new System.Drawing.Point(498, 309);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(174, 39);
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
            this.btnAVGRate.Location = new System.Drawing.Point(332, 309);
            this.btnAVGRate.Name = "btnAVGRate";
            this.btnAVGRate.Size = new System.Drawing.Size(160, 39);
            this.btnAVGRate.TabIndex = 24;
            this.btnAVGRate.Text = "Số Sao Trung Bình";
            this.btnAVGRate.UseVisualStyleBackColor = false;
            this.btnAVGRate.Click += new System.EventHandler(this.btnAVGRate_Click);
            // 
            // dgvQLDanhGia
            // 
            this.dgvQLDanhGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.dgvQLDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDanhGia.Location = new System.Drawing.Point(24, 130);
            this.dgvQLDanhGia.Name = "dgvQLDanhGia";
            this.dgvQLDanhGia.RowHeadersWidth = 51;
            this.dgvQLDanhGia.Size = new System.Drawing.Size(648, 172);
            this.dgvQLDanhGia.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 89);
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
            this.label1.Location = new System.Drawing.Point(249, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ ĐÁNH GIÁ";
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Location = new System.Drawing.Point(568, 91);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(104, 37);
            this.btn_Find.TabIndex = 34;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // FormQuanLyDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(702, 362);
            this.Controls.Add(this.panel1);
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