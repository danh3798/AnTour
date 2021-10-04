
namespace AnTour.ChildForm
{
    partial class FormQLKH
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
            this.lsvKhachHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKH_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtKH_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKH_diachi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnKH_anh = new FontAwesome.Sharp.IconButton();
            this.btnKH_huy = new FontAwesome.Sharp.IconButton();
            this.btnKH_xoa = new FontAwesome.Sharp.IconButton();
            this.btnKH_sua = new FontAwesome.Sharp.IconButton();
            this.btnKH_them = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.picboxKH = new System.Windows.Forms.PictureBox();
            this.txtKH_usrn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKH_pwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKH_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKH_sdt = new System.Windows.Forms.TextBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKH_cmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKH_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKH_ma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKH)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvKhachHang
            // 
            this.lsvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvKhachHang.FullRowSelect = true;
            this.lsvKhachHang.GridLines = true;
            this.lsvKhachHang.HideSelection = false;
            this.lsvKhachHang.Location = new System.Drawing.Point(3, 44);
            this.lsvKhachHang.Name = "lsvKhachHang";
            this.lsvKhachHang.Size = new System.Drawing.Size(1065, 383);
            this.lsvKhachHang.TabIndex = 0;
            this.lsvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lsvKhachHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách hàng";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 52;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CMND";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa chỉ";
            this.columnHeader6.Width = 112;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số điện thoại";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 151;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên tài khoản";
            this.columnHeader9.Width = 112;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mật khẩu";
            this.columnHeader10.Width = 134;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lsvKhachHang);
            this.groupBox1.Controls.Add(this.txtKH_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // txtKH_search
            // 
            this.txtKH_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_search.Location = new System.Drawing.Point(107, 16);
            this.txtKH_search.Name = "txtKH_search";
            this.txtKH_search.Size = new System.Drawing.Size(188, 20);
            this.txtKH_search.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dtKH_ngaysinh);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtKH_diachi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnKH_anh);
            this.groupBox2.Controls.Add(this.btnKH_huy);
            this.groupBox2.Controls.Add(this.btnKH_xoa);
            this.groupBox2.Controls.Add(this.btnKH_sua);
            this.groupBox2.Controls.Add(this.btnKH_them);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.picboxKH);
            this.groupBox2.Controls.Add(this.txtKH_usrn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKH_pwd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtKH_email);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtKH_sdt);
            this.groupBox2.Controls.Add(this.cbKhachHang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtKH_cmnd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtKH_ten);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKH_ma);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1074, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // dtKH_ngaysinh
            // 
            this.dtKH_ngaysinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtKH_ngaysinh.CustomFormat = "";
            this.dtKH_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKH_ngaysinh.Location = new System.Drawing.Point(160, 159);
            this.dtKH_ngaysinh.Name = "dtKH_ngaysinh";
            this.dtKH_ngaysinh.Size = new System.Drawing.Size(113, 20);
            this.dtKH_ngaysinh.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Địa chỉ:";
            // 
            // txtKH_diachi
            // 
            this.txtKH_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_diachi.Location = new System.Drawing.Point(436, 27);
            this.txtKH_diachi.Name = "txtKH_diachi";
            this.txtKH_diachi.Size = new System.Drawing.Size(185, 20);
            this.txtKH_diachi.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ngày sinh:";
            // 
            // btnKH_anh
            // 
            this.btnKH_anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKH_anh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_anh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKH_anh.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnKH_anh.IconColor = System.Drawing.Color.Black;
            this.btnKH_anh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKH_anh.IconSize = 25;
            this.btnKH_anh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH_anh.Location = new System.Drawing.Point(700, 178);
            this.btnKH_anh.Name = "btnKH_anh";
            this.btnKH_anh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKH_anh.Size = new System.Drawing.Size(98, 40);
            this.btnKH_anh.TabIndex = 24;
            this.btnKH_anh.Text = "      Duyệt tìm";
            this.btnKH_anh.UseVisualStyleBackColor = true;
            this.btnKH_anh.Click += new System.EventHandler(this.btnKH_anh_Click);
            // 
            // btnKH_huy
            // 
            this.btnKH_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKH_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKH_huy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnKH_huy.IconColor = System.Drawing.Color.Black;
            this.btnKH_huy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKH_huy.IconSize = 25;
            this.btnKH_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH_huy.Location = new System.Drawing.Point(448, 201);
            this.btnKH_huy.Name = "btnKH_huy";
            this.btnKH_huy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKH_huy.Size = new System.Drawing.Size(98, 40);
            this.btnKH_huy.TabIndex = 23;
            this.btnKH_huy.Text = "Hủy";
            this.btnKH_huy.UseVisualStyleBackColor = true;
            this.btnKH_huy.Click += new System.EventHandler(this.btnKH_huy_Click);
            // 
            // btnKH_xoa
            // 
            this.btnKH_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKH_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKH_xoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnKH_xoa.IconColor = System.Drawing.Color.Black;
            this.btnKH_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKH_xoa.IconSize = 25;
            this.btnKH_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH_xoa.Location = new System.Drawing.Point(332, 201);
            this.btnKH_xoa.Name = "btnKH_xoa";
            this.btnKH_xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKH_xoa.Size = new System.Drawing.Size(98, 40);
            this.btnKH_xoa.TabIndex = 22;
            this.btnKH_xoa.Text = "Xóa";
            this.btnKH_xoa.UseVisualStyleBackColor = true;
            this.btnKH_xoa.Click += new System.EventHandler(this.btnKH_xoa_Click);
            // 
            // btnKH_sua
            // 
            this.btnKH_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKH_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKH_sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnKH_sua.IconColor = System.Drawing.Color.Black;
            this.btnKH_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKH_sua.IconSize = 25;
            this.btnKH_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH_sua.Location = new System.Drawing.Point(216, 201);
            this.btnKH_sua.Name = "btnKH_sua";
            this.btnKH_sua.Size = new System.Drawing.Size(98, 40);
            this.btnKH_sua.TabIndex = 21;
            this.btnKH_sua.Text = "Sửa";
            this.btnKH_sua.UseVisualStyleBackColor = true;
            this.btnKH_sua.Click += new System.EventHandler(this.btnKH_sua_Click);
            // 
            // btnKH_them
            // 
            this.btnKH_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKH_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKH_them.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnKH_them.IconColor = System.Drawing.Color.Black;
            this.btnKH_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKH_them.IconSize = 25;
            this.btnKH_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH_them.Location = new System.Drawing.Point(100, 201);
            this.btnKH_them.Name = "btnKH_them";
            this.btnKH_them.Size = new System.Drawing.Size(98, 40);
            this.btnKH_them.TabIndex = 20;
            this.btnKH_them.Text = "Thêm";
            this.btnKH_them.UseVisualStyleBackColor = true;
            this.btnKH_them.Click += new System.EventHandler(this.btnKH_them_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Location = new System.Drawing.Point(813, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ảnh chân dung:";
            // 
            // picboxKH
            // 
            this.picboxKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxKH.Image = global::AnTour.Properties.Resources.user_blank;
            this.picboxKH.Location = new System.Drawing.Point(816, 41);
            this.picboxKH.Name = "picboxKH";
            this.picboxKH.Size = new System.Drawing.Size(150, 193);
            this.picboxKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxKH.TabIndex = 18;
            this.picboxKH.TabStop = false;
            // 
            // txtKH_usrn
            // 
            this.txtKH_usrn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_usrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_usrn.Location = new System.Drawing.Point(437, 124);
            this.txtKH_usrn.Name = "txtKH_usrn";
            this.txtKH_usrn.Size = new System.Drawing.Size(134, 20);
            this.txtKH_usrn.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mật khẩu:";
            // 
            // txtKH_pwd
            // 
            this.txtKH_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_pwd.Location = new System.Drawing.Point(437, 159);
            this.txtKH_pwd.Name = "txtKH_pwd";
            this.txtKH_pwd.Size = new System.Drawing.Size(134, 20);
            this.txtKH_pwd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên tài khoản:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email:";
            // 
            // txtKH_email
            // 
            this.txtKH_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_email.Location = new System.Drawing.Point(437, 92);
            this.txtKH_email.Name = "txtKH_email";
            this.txtKH_email.Size = new System.Drawing.Size(166, 20);
            this.txtKH_email.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số điện thoại:";
            // 
            // txtKH_sdt
            // 
            this.txtKH_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_sdt.Location = new System.Drawing.Point(437, 60);
            this.txtKH_sdt.Name = "txtKH_sdt";
            this.txtKH_sdt.Size = new System.Drawing.Size(146, 20);
            this.txtKH_sdt.TabIndex = 10;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbKhachHang.Location = new System.Drawing.Point(161, 91);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(70, 21);
            this.cbKhachHang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số CMND:";
            // 
            // txtKH_cmnd
            // 
            this.txtKH_cmnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_cmnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_cmnd.Location = new System.Drawing.Point(161, 126);
            this.txtKH_cmnd.Name = "txtKH_cmnd";
            this.txtKH_cmnd.Size = new System.Drawing.Size(134, 20);
            this.txtKH_cmnd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên:";
            // 
            // txtKH_ten
            // 
            this.txtKH_ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_ten.Location = new System.Drawing.Point(161, 59);
            this.txtKH_ten.Name = "txtKH_ten";
            this.txtKH_ten.Size = new System.Drawing.Size(166, 20);
            this.txtKH_ten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng:";
            // 
            // txtKH_ma
            // 
            this.txtKH_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKH_ma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKH_ma.Location = new System.Drawing.Point(161, 27);
            this.txtKH_ma.Name = "txtKH_ma";
            this.txtKH_ma.Size = new System.Drawing.Size(104, 20);
            this.txtKH_ma.TabIndex = 1;
            // 
            // FormQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1074, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLKH";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FormQLKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvKhachHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKH_search;
        private FontAwesome.Sharp.IconButton btnKH_them;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picboxKH;
        private System.Windows.Forms.TextBox txtKH_usrn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKH_pwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKH_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKH_sdt;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKH_cmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKH_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKH_ma;
        private FontAwesome.Sharp.IconButton btnKH_anh;
        private FontAwesome.Sharp.IconButton btnKH_huy;
        private FontAwesome.Sharp.IconButton btnKH_xoa;
        private FontAwesome.Sharp.IconButton btnKH_sua;
        private System.Windows.Forms.DateTimePicker dtKH_ngaysinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKH_diachi;
        private System.Windows.Forms.Label label12;
    }
}