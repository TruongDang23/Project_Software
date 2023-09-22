namespace ProjectTourism
{
    partial class FormDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhGia = new System.Windows.Forms.DataGridView();
            this.btnAVGSao = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnAVGSao);
            this.panel1.Controls.Add(this.dgvDanhGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 279);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(190, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ ĐÁNH GIÁ";
            // 
            // dgvDanhGia
            // 
            this.dgvDanhGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhGia.Location = new System.Drawing.Point(18, 72);
            this.dgvDanhGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.RowHeadersWidth = 51;
            this.dgvDanhGia.RowTemplate.Height = 24;
            this.dgvDanhGia.Size = new System.Drawing.Size(595, 149);
            this.dgvDanhGia.TabIndex = 4;
            // 
            // btnAVGSao
            // 
            this.btnAVGSao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnAVGSao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAVGSao.ForeColor = System.Drawing.Color.White;
            this.btnAVGSao.Location = new System.Drawing.Point(318, 225);
            this.btnAVGSao.Margin = new System.Windows.Forms.Padding(2);
            this.btnAVGSao.Name = "btnAVGSao";
            this.btnAVGSao.Size = new System.Drawing.Size(170, 39);
            this.btnAVGSao.TabIndex = 35;
            this.btnAVGSao.Text = "Số Sao Trung Binh";
            this.btnAVGSao.UseVisualStyleBackColor = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(512, 225);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(101, 41);
            this.btnQuayLai.TabIndex = 36;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // FormDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(636, 290);
            this.Controls.Add(this.panel1);
            this.Name = "FormDanhGia";
            this.Text = "FormDanhGia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhGia;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnAVGSao;
    }
}