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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_account = new System.Windows.Forms.Panel();
            this.pnl_tour = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_mess = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_hdv = new System.Windows.Forms.DataGridView();
            this.dgv_dataacc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_accxoa = new System.Windows.Forms.Button();
            this.btn_accsua = new System.Windows.Forms.Button();
            this.btn_accthem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pnl_dataacc = new System.Windows.Forms.Panel();
            this.dgv_dangky = new System.Windows.Forms.DataGridView();
            this.dgv_hanhkhach = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbb_idtour = new System.Windows.Forms.ComboBox();
            this.cbb_ten = new System.Windows.Forms.ComboBox();
            this.cbb_date = new System.Windows.Forms.ComboBox();
            this.cbb_cccd = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.pnl_hanhkhach = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_khthem = new System.Windows.Forms.Button();
            this.btn_khsua = new System.Windows.Forms.Button();
            this.btn_khxoa = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_kh = new System.Windows.Forms.TextBox();
            this.dgv_yeucau = new System.Windows.Forms.DataGridView();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dgv_idacc = new System.Windows.Forms.DataGridView();
            this.cbb_idacc = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_tieude = new System.Windows.Forms.TextBox();
            this.tb_noidung = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pnl_account.SuspendLayout();
            this.pnl_tour.SuspendLayout();
            this.pnl_mess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataacc)).BeginInit();
            this.pnl_dataacc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanhkhach)).BeginInit();
            this.pnl_hanhkhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yeucau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_idacc)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_title.Location = new System.Drawing.Point(392, 22);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(410, 38);
            this.lb_title.TabIndex = 5;
            this.lb_title.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tài khoản người dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_account
            // 
            this.pnl_account.BackColor = System.Drawing.Color.White;
            this.pnl_account.Controls.Add(this.dgv_dangky);
            this.pnl_account.Controls.Add(this.pnl_dataacc);
            this.pnl_account.Controls.Add(this.label9);
            this.pnl_account.Controls.Add(this.label1);
            this.pnl_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.pnl_account.Location = new System.Drawing.Point(25, 66);
            this.pnl_account.Name = "pnl_account";
            this.pnl_account.Size = new System.Drawing.Size(394, 674);
            this.pnl_account.TabIndex = 31;
            // 
            // pnl_tour
            // 
            this.pnl_tour.BackColor = System.Drawing.Color.White;
            this.pnl_tour.Controls.Add(this.tb_kh);
            this.pnl_tour.Controls.Add(this.label18);
            this.pnl_tour.Controls.Add(this.label17);
            this.pnl_tour.Controls.Add(this.cbb_id);
            this.pnl_tour.Controls.Add(this.label16);
            this.pnl_tour.Controls.Add(this.pnl_hanhkhach);
            this.pnl_tour.Controls.Add(this.dgv_hdv);
            this.pnl_tour.Controls.Add(this.label2);
            this.pnl_tour.Location = new System.Drawing.Point(422, 66);
            this.pnl_tour.Name = "pnl_tour";
            this.pnl_tour.Size = new System.Drawing.Size(394, 674);
            this.pnl_tour.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 42);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hành khách trên các tour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_mess
            // 
            this.pnl_mess.BackColor = System.Drawing.Color.White;
            this.pnl_mess.Controls.Add(this.label22);
            this.pnl_mess.Controls.Add(this.label21);
            this.pnl_mess.Controls.Add(this.tb_noidung);
            this.pnl_mess.Controls.Add(this.tb_tieude);
            this.pnl_mess.Controls.Add(this.cbb_idacc);
            this.pnl_mess.Controls.Add(this.label20);
            this.pnl_mess.Controls.Add(this.dgv_idacc);
            this.pnl_mess.Controls.Add(this.label19);
            this.pnl_mess.Controls.Add(this.btn_nhan);
            this.pnl_mess.Controls.Add(this.dgv_yeucau);
            this.pnl_mess.Controls.Add(this.btn_huy);
            this.pnl_mess.Controls.Add(this.label3);
            this.pnl_mess.Location = new System.Drawing.Point(817, 66);
            this.pnl_mess.Name = "pnl_mess";
            this.pnl_mess.Size = new System.Drawing.Size(394, 674);
            this.pnl_mess.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yêu cầu của người dùng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_hdv
            // 
            this.dgv_hdv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_hdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hdv.GridColor = System.Drawing.Color.Black;
            this.dgv_hdv.Location = new System.Drawing.Point(-275, 162);
            this.dgv_hdv.Name = "dgv_hdv";
            this.dgv_hdv.RowHeadersWidth = 51;
            this.dgv_hdv.RowTemplate.Height = 24;
            this.dgv_hdv.Size = new System.Drawing.Size(207, 256);
            this.dgv_hdv.TabIndex = 31;
            // 
            // dgv_dataacc
            // 
            this.dgv_dataacc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dataacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataacc.GridColor = System.Drawing.Color.Black;
            this.dgv_dataacc.Location = new System.Drawing.Point(4, 12);
            this.dgv_dataacc.Name = "dgv_dataacc";
            this.dgv_dataacc.RowHeadersWidth = 51;
            this.dgv_dataacc.RowTemplate.Height = 24;
            this.dgv_dataacc.Size = new System.Drawing.Size(355, 164);
            this.dgv_dataacc.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Thông tin tài khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "SDT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "Địa chỉ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_sdt
            // 
            this.tb_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_sdt.Location = new System.Drawing.Point(152, 238);
            this.tb_sdt.Multiline = true;
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(202, 25);
            this.tb_sdt.TabIndex = 33;
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_ten.Location = new System.Drawing.Point(152, 207);
            this.tb_ten.Multiline = true;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(202, 25);
            this.tb_ten.TabIndex = 37;
            // 
            // tb_diachi
            // 
            this.tb_diachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_diachi.Location = new System.Drawing.Point(152, 269);
            this.tb_diachi.Multiline = true;
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(202, 27);
            this.tb_diachi.TabIndex = 38;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_email.Location = new System.Drawing.Point(152, 302);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(202, 30);
            this.tb_email.TabIndex = 39;
            // 
            // btn_accxoa
            // 
            this.btn_accxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_accxoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_accxoa.Location = new System.Drawing.Point(235, 338);
            this.btn_accxoa.Name = "btn_accxoa";
            this.btn_accxoa.Size = new System.Drawing.Size(101, 48);
            this.btn_accxoa.TabIndex = 40;
            this.btn_accxoa.Text = "Xóa";
            this.btn_accxoa.UseVisualStyleBackColor = false;
            // 
            // btn_accsua
            // 
            this.btn_accsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_accsua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_accsua.Location = new System.Drawing.Point(128, 338);
            this.btn_accsua.Name = "btn_accsua";
            this.btn_accsua.Size = new System.Drawing.Size(101, 48);
            this.btn_accsua.TabIndex = 41;
            this.btn_accsua.Text = "Sửa";
            this.btn_accsua.UseVisualStyleBackColor = false;
            // 
            // btn_accthem
            // 
            this.btn_accthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_accthem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_accthem.Location = new System.Drawing.Point(18, 338);
            this.btn_accthem.Name = "btn_accthem";
            this.btn_accthem.Size = new System.Drawing.Size(101, 48);
            this.btn_accthem.TabIndex = 42;
            this.btn_accthem.Text = "Thêm";
            this.btn_accthem.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 42);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tour đã đăng ký";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pnl_dataacc
            // 
            this.pnl_dataacc.BackColor = System.Drawing.Color.Transparent;
            this.pnl_dataacc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dataacc.Controls.Add(this.dgv_dataacc);
            this.pnl_dataacc.Controls.Add(this.label4);
            this.pnl_dataacc.Controls.Add(this.btn_accthem);
            this.pnl_dataacc.Controls.Add(this.label5);
            this.pnl_dataacc.Controls.Add(this.btn_accsua);
            this.pnl_dataacc.Controls.Add(this.label6);
            this.pnl_dataacc.Controls.Add(this.btn_accxoa);
            this.pnl_dataacc.Controls.Add(this.tb_email);
            this.pnl_dataacc.Controls.Add(this.label7);
            this.pnl_dataacc.Controls.Add(this.tb_diachi);
            this.pnl_dataacc.Controls.Add(this.label8);
            this.pnl_dataacc.Controls.Add(this.tb_ten);
            this.pnl_dataacc.Controls.Add(this.tb_sdt);
            this.pnl_dataacc.Location = new System.Drawing.Point(15, 63);
            this.pnl_dataacc.Name = "pnl_dataacc";
            this.pnl_dataacc.Size = new System.Drawing.Size(364, 400);
            this.pnl_dataacc.TabIndex = 31;
            // 
            // dgv_dangky
            // 
            this.dgv_dangky.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_dangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dangky.GridColor = System.Drawing.Color.Black;
            this.dgv_dangky.Location = new System.Drawing.Point(20, 504);
            this.dgv_dangky.Name = "dgv_dangky";
            this.dgv_dangky.RowHeadersWidth = 51;
            this.dgv_dangky.RowTemplate.Height = 24;
            this.dgv_dangky.Size = new System.Drawing.Size(355, 157);
            this.dgv_dangky.TabIndex = 43;
            // 
            // dgv_hanhkhach
            // 
            this.dgv_hanhkhach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_hanhkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hanhkhach.GridColor = System.Drawing.Color.Black;
            this.dgv_hanhkhach.Location = new System.Drawing.Point(15, 0);
            this.dgv_hanhkhach.Name = "dgv_hanhkhach";
            this.dgv_hanhkhach.RowHeadersWidth = 51;
            this.dgv_hanhkhach.RowTemplate.Height = 24;
            this.dgv_hanhkhach.Size = new System.Drawing.Size(355, 164);
            this.dgv_hanhkhach.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 28);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tìm kiếm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "ID Tour";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(197, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "Tên";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(11, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 27);
            this.label13.TabIndex = 47;
            this.label13.Text = "Ngày đi";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(197, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 30);
            this.label14.TabIndex = 48;
            this.label14.Text = "CCCD";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_idtour
            // 
            this.cbb_idtour.FormattingEnabled = true;
            this.cbb_idtour.Location = new System.Drawing.Point(89, 200);
            this.cbb_idtour.Name = "cbb_idtour";
            this.cbb_idtour.Size = new System.Drawing.Size(102, 24);
            this.cbb_idtour.TabIndex = 49;
            // 
            // cbb_ten
            // 
            this.cbb_ten.FormattingEnabled = true;
            this.cbb_ten.Location = new System.Drawing.Point(263, 200);
            this.cbb_ten.Name = "cbb_ten";
            this.cbb_ten.Size = new System.Drawing.Size(102, 24);
            this.cbb_ten.TabIndex = 50;
            // 
            // cbb_date
            // 
            this.cbb_date.FormattingEnabled = true;
            this.cbb_date.Location = new System.Drawing.Point(89, 242);
            this.cbb_date.Name = "cbb_date";
            this.cbb_date.Size = new System.Drawing.Size(102, 24);
            this.cbb_date.TabIndex = 51;
            // 
            // cbb_cccd
            // 
            this.cbb_cccd.FormattingEnabled = true;
            this.cbb_cccd.Location = new System.Drawing.Point(263, 242);
            this.cbb_cccd.Name = "cbb_cccd";
            this.cbb_cccd.Size = new System.Drawing.Size(102, 24);
            this.cbb_cccd.TabIndex = 52;
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_loc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loc.Location = new System.Drawing.Point(15, 282);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(350, 39);
            this.btn_loc.TabIndex = 43;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            // 
            // pnl_hanhkhach
            // 
            this.pnl_hanhkhach.Controls.Add(this.btn_khthem);
            this.pnl_hanhkhach.Controls.Add(this.label15);
            this.pnl_hanhkhach.Controls.Add(this.btn_khsua);
            this.pnl_hanhkhach.Controls.Add(this.btn_loc);
            this.pnl_hanhkhach.Controls.Add(this.btn_khxoa);
            this.pnl_hanhkhach.Controls.Add(this.dgv_hanhkhach);
            this.pnl_hanhkhach.Controls.Add(this.cbb_cccd);
            this.pnl_hanhkhach.Controls.Add(this.label14);
            this.pnl_hanhkhach.Controls.Add(this.cbb_date);
            this.pnl_hanhkhach.Controls.Add(this.label13);
            this.pnl_hanhkhach.Controls.Add(this.cbb_ten);
            this.pnl_hanhkhach.Controls.Add(this.label12);
            this.pnl_hanhkhach.Controls.Add(this.cbb_idtour);
            this.pnl_hanhkhach.Controls.Add(this.label11);
            this.pnl_hanhkhach.Controls.Add(this.label10);
            this.pnl_hanhkhach.Location = new System.Drawing.Point(0, 45);
            this.pnl_hanhkhach.Name = "pnl_hanhkhach";
            this.pnl_hanhkhach.Size = new System.Drawing.Size(394, 474);
            this.pnl_hanhkhach.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(25, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(323, 27);
            this.label15.TabIndex = 44;
            this.label15.Text = "Chỉnh sửa thông tin";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_khthem
            // 
            this.btn_khthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_khthem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khthem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khthem.Location = new System.Drawing.Point(30, 415);
            this.btn_khthem.Name = "btn_khthem";
            this.btn_khthem.Size = new System.Drawing.Size(101, 48);
            this.btn_khthem.TabIndex = 45;
            this.btn_khthem.Text = "Thêm";
            this.btn_khthem.UseVisualStyleBackColor = false;
            // 
            // btn_khsua
            // 
            this.btn_khsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_khsua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khsua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khsua.Location = new System.Drawing.Point(140, 415);
            this.btn_khsua.Name = "btn_khsua";
            this.btn_khsua.Size = new System.Drawing.Size(101, 48);
            this.btn_khsua.TabIndex = 44;
            this.btn_khsua.Text = "Sửa";
            this.btn_khsua.UseVisualStyleBackColor = false;
            // 
            // btn_khxoa
            // 
            this.btn_khxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_khxoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_khxoa.Location = new System.Drawing.Point(247, 415);
            this.btn_khxoa.Name = "btn_khxoa";
            this.btn_khxoa.Size = new System.Drawing.Size(101, 48);
            this.btn_khxoa.TabIndex = 43;
            this.btn_khxoa.Text = "Xóa";
            this.btn_khxoa.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(42, 538);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(323, 27);
            this.label16.TabIndex = 53;
            this.label16.Text = "Thống kê";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_id
            // 
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(30, 617);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(102, 24);
            this.cbb_id.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(43, 576);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 25);
            this.label17.TabIndex = 53;
            this.label17.Text = "ID Tour";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(212, 576);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 25);
            this.label18.TabIndex = 53;
            this.label18.Text = "Số hành khách";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_kh
            // 
            this.tb_kh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_kh.Location = new System.Drawing.Point(178, 604);
            this.tb_kh.Multiline = true;
            this.tb_kh.Name = "tb_kh";
            this.tb_kh.Size = new System.Drawing.Size(202, 37);
            this.tb_kh.TabIndex = 43;
            // 
            // dgv_yeucau
            // 
            this.dgv_yeucau.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_yeucau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yeucau.GridColor = System.Drawing.Color.Black;
            this.dgv_yeucau.Location = new System.Drawing.Point(20, 76);
            this.dgv_yeucau.Name = "dgv_yeucau";
            this.dgv_yeucau.RowHeadersWidth = 51;
            this.dgv_yeucau.RowTemplate.Height = 24;
            this.dgv_yeucau.Size = new System.Drawing.Size(355, 164);
            this.dgv_yeucau.TabIndex = 53;
            // 
            // btn_nhan
            // 
            this.btn_nhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_nhan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_nhan.Location = new System.Drawing.Point(20, 246);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(166, 50);
            this.btn_nhan.TabIndex = 54;
            this.btn_nhan.Text = "Nhận";
            this.btn_nhan.UseVisualStyleBackColor = false;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_huy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(206, 246);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(169, 50);
            this.btn_huy.TabIndex = 53;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(36, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(323, 42);
            this.label19.TabIndex = 55;
            this.label19.Text = "Trao đổi và liên lạc";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_idacc
            // 
            this.dgv_idacc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_idacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_idacc.GridColor = System.Drawing.Color.Black;
            this.dgv_idacc.Location = new System.Drawing.Point(20, 361);
            this.dgv_idacc.Name = "dgv_idacc";
            this.dgv_idacc.RowHeadersWidth = 51;
            this.dgv_idacc.RowTemplate.Height = 24;
            this.dgv_idacc.Size = new System.Drawing.Size(81, 292);
            this.dgv_idacc.TabIndex = 56;
            // 
            // cbb_idacc
            // 
            this.cbb_idacc.FormattingEnabled = true;
            this.cbb_idacc.Location = new System.Drawing.Point(273, 372);
            this.cbb_idacc.Name = "cbb_idacc";
            this.cbb_idacc.Size = new System.Drawing.Size(102, 24);
            this.cbb_idacc.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(143, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 25);
            this.label20.TabIndex = 53;
            this.label20.Text = "ID Account";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_tieude
            // 
            this.tb_tieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_tieude.Location = new System.Drawing.Point(228, 412);
            this.tb_tieude.Multiline = true;
            this.tb_tieude.Name = "tb_tieude";
            this.tb_tieude.Size = new System.Drawing.Size(147, 25);
            this.tb_tieude.TabIndex = 43;
            // 
            // tb_noidung
            // 
            this.tb_noidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.tb_noidung.Location = new System.Drawing.Point(147, 491);
            this.tb_noidung.Multiline = true;
            this.tb_noidung.Name = "tb_noidung";
            this.tb_noidung.Size = new System.Drawing.Size(228, 162);
            this.tb_noidung.TabIndex = 43;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(143, 413);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 25);
            this.label21.TabIndex = 57;
            this.label21.Text = "Tiêu đề";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(143, 450);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(232, 25);
            this.label22.TabIndex = 58;
            this.label22.Text = "Nội dung";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1248, 767);
            this.Controls.Add(this.pnl_mess);
            this.Controls.Add(this.pnl_tour);
            this.Controls.Add(this.pnl_account);
            this.Controls.Add(this.lb_title);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.pnl_account.ResumeLayout(false);
            this.pnl_tour.ResumeLayout(false);
            this.pnl_tour.PerformLayout();
            this.pnl_mess.ResumeLayout(false);
            this.pnl_mess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataacc)).EndInit();
            this.pnl_dataacc.ResumeLayout(false);
            this.pnl_dataacc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanhkhach)).EndInit();
            this.pnl_hanhkhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yeucau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_idacc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_account;
        private System.Windows.Forms.Panel pnl_tour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_mess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_hdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_dataacc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.DataGridView dgv_dangky;
        private System.Windows.Forms.Panel pnl_dataacc;
        private System.Windows.Forms.Button btn_accthem;
        private System.Windows.Forms.Button btn_accsua;
        private System.Windows.Forms.Button btn_accxoa;
        private System.Windows.Forms.Label label9;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_hanhkhach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_kh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbb_id;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnl_hanhkhach;
        private System.Windows.Forms.Button btn_khthem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_khsua;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Button btn_khxoa;
        private System.Windows.Forms.ComboBox cbb_cccd;
        private System.Windows.Forms.ComboBox cbb_date;
        private System.Windows.Forms.ComboBox cbb_ten;
        private System.Windows.Forms.ComboBox cbb_idtour;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_noidung;
        private System.Windows.Forms.TextBox tb_tieude;
        private System.Windows.Forms.ComboBox cbb_idacc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgv_idacc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.DataGridView dgv_yeucau;
        private System.Windows.Forms.Button btn_huy;
    }
}