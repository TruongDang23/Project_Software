namespace ProjectTourism
{
    partial class FormQuanLyHanhKhach
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
            this.pnl_tour = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_hanhkhach = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.pnl_modify = new System.Windows.Forms.Panel();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_save = new System.Windows.Forms.Panel();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dtp_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.tb_cccd = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_ten = new System.Windows.Forms.CheckBox();
            this.cb_cccd = new System.Windows.Forms.CheckBox();
            this.cb_Id = new System.Windows.Forms.CheckBox();
            this.cb_ngaydi = new System.Windows.Forms.CheckBox();
            this.cbb_cccd = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_idtour = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbb_ten = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbb_date = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl_thongke = new System.Windows.Forms.Panel();
            this.cbb_ngaydi_tk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_kh = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbb_id_tk = new System.Windows.Forms.ComboBox();
            this.dgv_hanhkhach = new System.Windows.Forms.DataGridView();
            this.dgv_hdv = new System.Windows.Forms.DataGridView();
            this.pnl_tour.SuspendLayout();
            this.pnl_hanhkhach.SuspendLayout();
            this.pnl_modify.SuspendLayout();
            this.pnl_save.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanhkhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_tour
            // 
            this.pnl_tour.BackColor = System.Drawing.Color.White;
            this.pnl_tour.Controls.Add(this.label2);
            this.pnl_tour.Controls.Add(this.pnl_hanhkhach);
            this.pnl_tour.Controls.Add(this.dgv_hdv);
            this.pnl_tour.Location = new System.Drawing.Point(12, 12);
            this.pnl_tour.Name = "pnl_tour";
            this.pnl_tour.Size = new System.Drawing.Size(1020, 606);
            this.pnl_tour.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(969, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Quản lý hành khách trên các tour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_hanhkhach
            // 
            this.pnl_hanhkhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_hanhkhach.Controls.Add(this.btn_reload);
            this.pnl_hanhkhach.Controls.Add(this.pnl_modify);
            this.pnl_hanhkhach.Controls.Add(this.panel1);
            this.pnl_hanhkhach.Controls.Add(this.pnl_thongke);
            this.pnl_hanhkhach.Controls.Add(this.dgv_hanhkhach);
            this.pnl_hanhkhach.Location = new System.Drawing.Point(12, 45);
            this.pnl_hanhkhach.Name = "pnl_hanhkhach";
            this.pnl_hanhkhach.Size = new System.Drawing.Size(996, 543);
            this.pnl_hanhkhach.TabIndex = 53;
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.White;
            this.btn_reload.BackgroundImage = global::ProjectTourism.Properties.Resources.reload;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reload.Location = new System.Drawing.Point(691, 8);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(40, 40);
            this.btn_reload.TabIndex = 57;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // pnl_modify
            // 
            this.pnl_modify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_modify.Controls.Add(this.tb_sdt);
            this.pnl_modify.Controls.Add(this.label6);
            this.pnl_modify.Controls.Add(this.pnl_save);
            this.pnl_modify.Controls.Add(this.dtp_ngaydi);
            this.pnl_modify.Controls.Add(this.tb_cccd);
            this.pnl_modify.Controls.Add(this.tb_ten);
            this.pnl_modify.Controls.Add(this.tb_id);
            this.pnl_modify.Controls.Add(this.label1);
            this.pnl_modify.Controls.Add(this.label3);
            this.pnl_modify.Controls.Add(this.label4);
            this.pnl_modify.Controls.Add(this.label5);
            this.pnl_modify.Controls.Add(this.label15);
            this.pnl_modify.Controls.Add(this.btn_xoa);
            this.pnl_modify.Controls.Add(this.btn_sua);
            this.pnl_modify.Controls.Add(this.btn_them);
            this.pnl_modify.Location = new System.Drawing.Point(467, 252);
            this.pnl_modify.Name = "pnl_modify";
            this.pnl_modify.Size = new System.Drawing.Size(513, 274);
            this.pnl_modify.TabIndex = 56;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(234, 221);
            this.tb_sdt.Multiline = true;
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(250, 35);
            this.tb_sdt.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(139, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "SDT:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_save
            // 
            this.pnl_save.Controls.Add(this.btn_huy);
            this.pnl_save.Controls.Add(this.btn_luu);
            this.pnl_save.Location = new System.Drawing.Point(-2, 158);
            this.pnl_save.Name = "pnl_save";
            this.pnl_save.Size = new System.Drawing.Size(114, 93);
            this.pnl_save.TabIndex = 60;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Location = new System.Drawing.Point(16, 5);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(76, 37);
            this.btn_huy.TabIndex = 59;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Location = new System.Drawing.Point(16, 48);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(76, 37);
            this.btn_luu.TabIndex = 43;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // dtp_ngaydi
            // 
            this.dtp_ngaydi.Location = new System.Drawing.Point(234, 99);
            this.dtp_ngaydi.Name = "dtp_ngaydi";
            this.dtp_ngaydi.Size = new System.Drawing.Size(250, 22);
            this.dtp_ngaydi.TabIndex = 58;
            // 
            // tb_cccd
            // 
            this.tb_cccd.Location = new System.Drawing.Point(234, 137);
            this.tb_cccd.Multiline = true;
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.Size = new System.Drawing.Size(250, 35);
            this.tb_cccd.TabIndex = 57;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(234, 180);
            this.tb_ten.Multiline = true;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(250, 35);
            this.tb_ten.TabIndex = 55;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(234, 46);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(250, 35);
            this.tb_id.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID Tour:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(139, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(139, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 27);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày đi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(139, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 52;
            this.label5.Text = "CCCD:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(143, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(341, 34);
            this.label15.TabIndex = 44;
            this.label15.Text = "Chỉnh sửa thông tin";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(16, 84);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(76, 37);
            this.btn_xoa.TabIndex = 43;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(16, 46);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(76, 37);
            this.btn_sua.TabIndex = 44;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(16, 7);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(76, 37);
            this.btn_them.TabIndex = 45;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cb_ten);
            this.panel1.Controls.Add(this.cb_cccd);
            this.panel1.Controls.Add(this.cb_Id);
            this.panel1.Controls.Add(this.cb_ngaydi);
            this.panel1.Controls.Add(this.cbb_cccd);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbb_idtour);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbb_ten);
            this.panel1.Controls.Add(this.btn_loc);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbb_date);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(15, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 274);
            this.panel1.TabIndex = 55;
            // 
            // cb_ten
            // 
            this.cb_ten.AutoSize = true;
            this.cb_ten.Location = new System.Drawing.Point(309, 177);
            this.cb_ten.Name = "cb_ten";
            this.cb_ten.Size = new System.Drawing.Size(93, 20);
            this.cb_ten.TabIndex = 56;
            this.cb_ten.Text = "Lọc với tên";
            this.cb_ten.UseVisualStyleBackColor = true;
            // 
            // cb_cccd
            // 
            this.cb_cccd.AutoSize = true;
            this.cb_cccd.Location = new System.Drawing.Point(309, 137);
            this.cb_cccd.Name = "cb_cccd";
            this.cb_cccd.Size = new System.Drawing.Size(112, 20);
            this.cb_cccd.TabIndex = 55;
            this.cb_cccd.Text = "Lọc với CCCD";
            this.cb_cccd.UseVisualStyleBackColor = true;
            // 
            // cb_Id
            // 
            this.cb_Id.AutoSize = true;
            this.cb_Id.Location = new System.Drawing.Point(309, 57);
            this.cb_Id.Name = "cb_Id";
            this.cb_Id.Size = new System.Drawing.Size(88, 20);
            this.cb_Id.TabIndex = 54;
            this.cb_Id.Text = "Lọc với ID";
            this.cb_Id.UseVisualStyleBackColor = true;
            // 
            // cb_ngaydi
            // 
            this.cb_ngaydi.AutoSize = true;
            this.cb_ngaydi.Location = new System.Drawing.Point(309, 100);
            this.cb_ngaydi.Name = "cb_ngaydi";
            this.cb_ngaydi.Size = new System.Drawing.Size(119, 20);
            this.cb_ngaydi.TabIndex = 53;
            this.cb_ngaydi.Text = "Lọc với ngày đi";
            this.cb_ngaydi.UseVisualStyleBackColor = true;
            // 
            // cbb_cccd
            // 
            this.cbb_cccd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_cccd.FormattingEnabled = true;
            this.cbb_cccd.Location = new System.Drawing.Point(114, 137);
            this.cbb_cccd.Name = "cbb_cccd";
            this.cbb_cccd.Size = new System.Drawing.Size(167, 25);
            this.cbb_cccd.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(404, 28);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tìm kiếm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "ID Tour:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_idtour
            // 
            this.cbb_idtour.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_idtour.FormattingEnabled = true;
            this.cbb_idtour.Location = new System.Drawing.Point(114, 56);
            this.cbb_idtour.Name = "cbb_idtour";
            this.cbb_idtour.Size = new System.Drawing.Size(167, 25);
            this.cbb_idtour.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(9, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "Tên:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_ten
            // 
            this.cbb_ten.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ten.FormattingEnabled = true;
            this.cbb_ten.Location = new System.Drawing.Point(114, 177);
            this.cbb_ten.Name = "cbb_ten";
            this.cbb_ten.Size = new System.Drawing.Size(167, 25);
            this.cbb_ten.TabIndex = 50;
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.btn_loc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loc.Location = new System.Drawing.Point(309, 212);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(112, 44);
            this.btn_loc.TabIndex = 43;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 27);
            this.label13.TabIndex = 47;
            this.label13.Text = "Ngày đi:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_date
            // 
            this.cbb_date.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_date.FormattingEnabled = true;
            this.cbb_date.Location = new System.Drawing.Point(114, 100);
            this.cbb_date.Name = "cbb_date";
            this.cbb_date.Size = new System.Drawing.Size(167, 25);
            this.cbb_date.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(9, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 30);
            this.label14.TabIndex = 48;
            this.label14.Text = "CCCD:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_thongke
            // 
            this.pnl_thongke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_thongke.Controls.Add(this.cbb_ngaydi_tk);
            this.pnl_thongke.Controls.Add(this.label7);
            this.pnl_thongke.Controls.Add(this.label17);
            this.pnl_thongke.Controls.Add(this.label18);
            this.pnl_thongke.Controls.Add(this.tb_kh);
            this.pnl_thongke.Controls.Add(this.label16);
            this.pnl_thongke.Controls.Add(this.cbb_id_tk);
            this.pnl_thongke.Location = new System.Drawing.Point(736, 8);
            this.pnl_thongke.Name = "pnl_thongke";
            this.pnl_thongke.Size = new System.Drawing.Size(244, 227);
            this.pnl_thongke.TabIndex = 54;
            // 
            // cbb_ngaydi_tk
            // 
            this.cbb_ngaydi_tk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ngaydi_tk.FormattingEnabled = true;
            this.cbb_ngaydi_tk.Location = new System.Drawing.Point(122, 118);
            this.cbb_ngaydi_tk.Name = "cbb_ngaydi_tk";
            this.cbb_ngaydi_tk.Size = new System.Drawing.Size(109, 25);
            this.cbb_ngaydi_tk.TabIndex = 55;
            this.cbb_ngaydi_tk.SelectedValueChanged += new System.EventHandler(this.cbb_ngaydi_tk_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-1, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 32);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ngày đi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(-1, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 32);
            this.label17.TabIndex = 53;
            this.label17.Text = "ID Tour:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 67);
            this.label18.TabIndex = 53;
            this.label18.Text = "Số hành khách:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_kh
            // 
            this.tb_kh.BackColor = System.Drawing.Color.White;
            this.tb_kh.Enabled = false;
            this.tb_kh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kh.Location = new System.Drawing.Point(153, 158);
            this.tb_kh.Multiline = true;
            this.tb_kh.Name = "tb_kh";
            this.tb_kh.Size = new System.Drawing.Size(59, 48);
            this.tb_kh.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(50, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 36);
            this.label16.TabIndex = 53;
            this.label16.Text = "Thống kê";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_id_tk
            // 
            this.cbb_id_tk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_id_tk.FormattingEnabled = true;
            this.cbb_id_tk.Location = new System.Drawing.Point(122, 59);
            this.cbb_id_tk.Name = "cbb_id_tk";
            this.cbb_id_tk.Size = new System.Drawing.Size(109, 25);
            this.cbb_id_tk.TabIndex = 53;
            this.cbb_id_tk.SelectedValueChanged += new System.EventHandler(this.cbb_id_tk_SelectedValueChanged);
            // 
            // dgv_hanhkhach
            // 
            this.dgv_hanhkhach.AllowUserToAddRows = false;
            this.dgv_hanhkhach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_hanhkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hanhkhach.GridColor = System.Drawing.Color.Black;
            this.dgv_hanhkhach.Location = new System.Drawing.Point(15, 8);
            this.dgv_hanhkhach.Name = "dgv_hanhkhach";
            this.dgv_hanhkhach.RowHeadersVisible = false;
            this.dgv_hanhkhach.RowHeadersWidth = 51;
            this.dgv_hanhkhach.RowTemplate.Height = 24;
            this.dgv_hanhkhach.Size = new System.Drawing.Size(670, 227);
            this.dgv_hanhkhach.TabIndex = 43;
            this.dgv_hanhkhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hanhkhach_CellClick);
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
            // FormQuanLyHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1044, 630);
            this.Controls.Add(this.pnl_tour);
            this.Name = "FormQuanLyHanhKhach";
            this.Text = "FormQuanLyHanhKhach";
            this.Load += new System.EventHandler(this.FormQuanLyHanhKhach_Load);
            this.pnl_tour.ResumeLayout(false);
            this.pnl_hanhkhach.ResumeLayout(false);
            this.pnl_modify.ResumeLayout(false);
            this.pnl_modify.PerformLayout();
            this.pnl_save.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_thongke.ResumeLayout(false);
            this.pnl_thongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanhkhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_tour;
        private System.Windows.Forms.TextBox tb_kh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbb_id_tk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnl_hanhkhach;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgv_hanhkhach;
        private System.Windows.Forms.ComboBox cbb_cccd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbb_date;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbb_ten;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbb_idtour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_hdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_thongke;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_cccd;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.DateTimePicker dtp_ngaydi;
        private System.Windows.Forms.Panel pnl_save;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_ten;
        private System.Windows.Forms.CheckBox cb_cccd;
        private System.Windows.Forms.CheckBox cb_Id;
        private System.Windows.Forms.CheckBox cb_ngaydi;
        private System.Windows.Forms.ComboBox cbb_ngaydi_tk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_reload;
    }
}