﻿namespace ProjectTourism
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
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnAVGRate);
            this.panel1.Controls.Add(this.dgvQLDanhGia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 323);
            this.panel1.TabIndex = 4;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuayLai.Location = new System.Drawing.Point(498, 276);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(174, 39);
            this.btnQuayLai.TabIndex = 25;
            this.btnQuayLai.Text = "Quay Lại Trang Chủ";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btnAVGRate
            // 
            this.btnAVGRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnAVGRate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAVGRate.FlatAppearance.BorderSize = 0;
            this.btnAVGRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAVGRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAVGRate.Location = new System.Drawing.Point(332, 276);
            this.btnAVGRate.Name = "btnAVGRate";
            this.btnAVGRate.Size = new System.Drawing.Size(160, 39);
            this.btnAVGRate.TabIndex = 24;
            this.btnAVGRate.Text = "Số Sao Trung Bình";
            this.btnAVGRate.UseVisualStyleBackColor = false;
            // 
            // dgvQLDanhGia
            // 
            this.dgvQLDanhGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.dgvQLDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDanhGia.Location = new System.Drawing.Point(24, 98);
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
            // FormQuanLyDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(702, 331);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyDanhGia";
            this.Text = "FormQuanLyDanhGia";
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
    }
}