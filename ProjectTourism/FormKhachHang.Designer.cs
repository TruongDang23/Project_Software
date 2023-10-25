namespace ProjectTourism
{
    partial class FormKhachHang
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
            this.lb_title = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnquanlytaikhoan = new System.Windows.Forms.Button();
            this.btnquanlyhanhkhach = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_title.Location = new System.Drawing.Point(106, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(392, 45);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnquanlyhanhkhach);
            this.panel1.Controls.Add(this.btnquanlytaikhoan);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 193);
            this.panel1.TabIndex = 34;
            // 
            // btnquanlytaikhoan
            // 
            this.btnquanlytaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnquanlytaikhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquanlytaikhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquanlytaikhoan.Location = new System.Drawing.Point(69, 16);
            this.btnquanlytaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnquanlytaikhoan.Name = "btnquanlytaikhoan";
            this.btnquanlytaikhoan.Size = new System.Drawing.Size(438, 43);
            this.btnquanlytaikhoan.TabIndex = 34;
            this.btnquanlytaikhoan.Text = "Quản lý tài khoản";
            this.btnquanlytaikhoan.UseVisualStyleBackColor = false;
            this.btnquanlytaikhoan.Click += new System.EventHandler(this.btnquanlytaikhoan_Click);
            // 
            // btnquanlyhanhkhach
            // 
            this.btnquanlyhanhkhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btnquanlyhanhkhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquanlyhanhkhach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquanlyhanhkhach.Location = new System.Drawing.Point(69, 74);
            this.btnquanlyhanhkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnquanlyhanhkhach.Name = "btnquanlyhanhkhach";
            this.btnquanlyhanhkhach.Size = new System.Drawing.Size(438, 43);
            this.btnquanlyhanhkhach.TabIndex = 35;
            this.btnquanlyhanhkhach.Text = "Quản lý hành khách trên các tour";
            this.btnquanlyhanhkhach.UseVisualStyleBackColor = false;
            this.btnquanlyhanhkhach.Click += new System.EventHandler(this.btnquanlyhanhkhach_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(69, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(438, 43);
            this.button2.TabIndex = 36;
            this.button2.Text = "Quản lý yêu cầu và liên lạc khách hàng\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(592, 269);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_title);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnquanlyhanhkhach;
        private System.Windows.Forms.Button btnquanlytaikhoan;
    }
}