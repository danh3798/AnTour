
namespace AnTour
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnTKBC = new FontAwesome.Sharp.IconButton();
            this.btnQLDT = new FontAwesome.Sharp.IconButton();
            this.btnQLT = new FontAwesome.Sharp.IconButton();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.btnQLKH = new FontAwesome.Sharp.IconButton();
            this.btnQLTD = new FontAwesome.Sharp.IconButton();
            this.btnDatTour = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.icChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChild = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icChildForm)).BeginInit();
            this.panelChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnTKBC);
            this.panelMenu.Controls.Add(this.btnQLDT);
            this.panelMenu.Controls.Add(this.btnQLT);
            this.panelMenu.Controls.Add(this.btnQLNV);
            this.panelMenu.Controls.Add(this.btnQLKH);
            this.panelMenu.Controls.Add(this.btnQLTD);
            this.panelMenu.Controls.Add(this.btnDatTour);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 629);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 579);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Tag = "   Đăng xuất";
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTKBC
            // 
            this.btnTKBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKBC.FlatAppearance.BorderSize = 0;
            this.btnTKBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKBC.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnTKBC.ForeColor = System.Drawing.Color.White;
            this.btnTKBC.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnTKBC.IconColor = System.Drawing.Color.White;
            this.btnTKBC.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTKBC.IconSize = 30;
            this.btnTKBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKBC.Location = new System.Drawing.Point(0, 415);
            this.btnTKBC.Name = "btnTKBC";
            this.btnTKBC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTKBC.Size = new System.Drawing.Size(250, 50);
            this.btnTKBC.TabIndex = 6;
            this.btnTKBC.Tag = "   Thống kê, báo cáo";
            this.btnTKBC.Text = "  Thống kê, báo cáo";
            this.btnTKBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKBC.UseVisualStyleBackColor = true;
            this.btnTKBC.Click += new System.EventHandler(this.btnTKBC_Click);
            // 
            // btnQLDT
            // 
            this.btnQLDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDT.FlatAppearance.BorderSize = 0;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnQLDT.ForeColor = System.Drawing.Color.White;
            this.btnQLDT.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnQLDT.IconColor = System.Drawing.Color.White;
            this.btnQLDT.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQLDT.IconSize = 30;
            this.btnQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.Location = new System.Drawing.Point(0, 365);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLDT.Size = new System.Drawing.Size(250, 50);
            this.btnQLDT.TabIndex = 5;
            this.btnQLDT.Tag = "   Quản lý đặt Tour";
            this.btnQLDT.Text = "  Quản lý đặt tour";
            this.btnQLDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDT.UseVisualStyleBackColor = true;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click);
            // 
            // btnQLT
            // 
            this.btnQLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLT.FlatAppearance.BorderSize = 0;
            this.btnQLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLT.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnQLT.ForeColor = System.Drawing.Color.White;
            this.btnQLT.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btnQLT.IconColor = System.Drawing.Color.White;
            this.btnQLT.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQLT.IconSize = 30;
            this.btnQLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLT.Location = new System.Drawing.Point(0, 315);
            this.btnQLT.Name = "btnQLT";
            this.btnQLT.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLT.Size = new System.Drawing.Size(250, 50);
            this.btnQLT.TabIndex = 4;
            this.btnQLT.Tag = "   Quản lý Tour";
            this.btnQLT.Text = "  Quản lý tour";
            this.btnQLT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLT.UseVisualStyleBackColor = true;
            this.btnQLT.Click += new System.EventHandler(this.btnQLT_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnQLNV.IconColor = System.Drawing.Color.White;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQLNV.IconSize = 30;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 265);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNV.Size = new System.Drawing.Size(250, 50);
            this.btnQLNV.TabIndex = 3;
            this.btnQLNV.Tag = "   Quản lý nhân viên";
            this.btnQLNV.Text = "  Quản lý nhân viên";
            this.btnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnQLKH.IconColor = System.Drawing.Color.White;
            this.btnQLKH.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQLKH.IconSize = 30;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(0, 215);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLKH.Size = new System.Drawing.Size(250, 50);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Tag = "   Quản lý khách hàng";
            this.btnQLKH.Text = "  Quản lý khách hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLTD
            // 
            this.btnQLTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
            this.btnQLTD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTD.FlatAppearance.BorderSize = 0;
            this.btnQLTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTD.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnQLTD.ForeColor = System.Drawing.Color.White;
            this.btnQLTD.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnQLTD.IconColor = System.Drawing.Color.White;
            this.btnQLTD.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQLTD.IconSize = 30;
            this.btnQLTD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTD.Location = new System.Drawing.Point(0, 165);
            this.btnQLTD.Name = "btnQLTD";
            this.btnQLTD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLTD.Size = new System.Drawing.Size(250, 50);
            this.btnQLTD.TabIndex = 8;
            this.btnQLTD.Tag = "   Quản lý tour đặt";
            this.btnQLTD.Text = "  Quản lý tour đặt";
            this.btnQLTD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTD.UseVisualStyleBackColor = false;
            this.btnQLTD.Click += new System.EventHandler(this.btnQLTD_Click);
            // 
            // btnDatTour
            // 
            this.btnDatTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
            this.btnDatTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatTour.FlatAppearance.BorderSize = 0;
            this.btnDatTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTour.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnDatTour.ForeColor = System.Drawing.Color.White;
            this.btnDatTour.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnDatTour.IconColor = System.Drawing.Color.White;
            this.btnDatTour.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDatTour.IconSize = 30;
            this.btnDatTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatTour.Location = new System.Drawing.Point(0, 115);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatTour.Size = new System.Drawing.Size(250, 50);
            this.btnDatTour.TabIndex = 1;
            this.btnDatTour.Tag = "   Đặt Tour";
            this.btnDatTour.Text = "  Đặt Tour";
            this.btnDatTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatTour.UseVisualStyleBackColor = false;
            this.btnDatTour.Click += new System.EventHandler(this.btnDatTour_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsn);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 115);
            this.panel1.TabIndex = 0;
            // 
            // lblUsn
            // 
            this.lblUsn.AutoSize = true;
            this.lblUsn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsn.ForeColor = System.Drawing.Color.White;
            this.lblUsn.Location = new System.Drawing.Point(98, 44);
            this.lblUsn.Name = "lblUsn";
            this.lblUsn.Size = new System.Drawing.Size(43, 16);
            this.lblUsn.TabIndex = 2;
            this.lblUsn.Text = "admin";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(97, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Vũ Đức Anh";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(190, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnTour.Properties.Resources.DTU_0727;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.panelTitleBar.Controls.Add(this.lblChildForm);
            this.panelTitleBar.Controls.Add(this.icChildForm);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(834, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.ForeColor = System.Drawing.Color.White;
            this.lblChildForm.Location = new System.Drawing.Point(57, 16);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(443, 24);
            this.lblChildForm.TabIndex = 6;
            this.lblChildForm.Text = "Hệ thống đăng kí du lịch miệt vườn AnTour";
            // 
            // icChildForm
            // 
            this.icChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.icChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icChildForm.IconColor = System.Drawing.Color.White;
            this.icChildForm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icChildForm.IconSize = 40;
            this.icChildForm.Location = new System.Drawing.Point(11, 11);
            this.icChildForm.Name = "icChildForm";
            this.icChildForm.Size = new System.Drawing.Size(40, 40);
            this.icChildForm.TabIndex = 5;
            this.icChildForm.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(202)))), ((int)(((byte)(101)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(701, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.iconButton11_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(746, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(789, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.SystemColors.Control;
            this.panelChild.BackgroundImage = global::AnTour.Properties.Resources.cantho2;
            this.panelChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChild.Controls.Add(this.lblDate);
            this.panelChild.Controls.Add(this.lblTime);
            this.panelChild.Controls.Add(this.lblUser);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 60);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(834, 569);
            this.panelChild.TabIndex = 2;
            this.panelChild.Tag = "";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Averta Light", 14F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(32, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "lblDate";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Averta", 24F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(30, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 38);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "lblTime";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(31, 465);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(616, 64);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Xin chào Vũ Đức Anh - ADMIN\r\nĐể bắt đầu hãy chọn các chức năng bên cạnh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1084, 629);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnTour";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icChildForm)).EndInit();
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelChild;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnTKBC;
        private FontAwesome.Sharp.IconButton btnQLDT;
        private FontAwesome.Sharp.IconButton btnQLT;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private FontAwesome.Sharp.IconButton btnQLKH;
        private FontAwesome.Sharp.IconButton btnDatTour;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblChildForm;
        private FontAwesome.Sharp.IconPictureBox icChildForm;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUsn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnQLTD;
    }
}

