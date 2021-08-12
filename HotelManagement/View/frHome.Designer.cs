
namespace HotelManagement.View
{
    partial class frHome
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_statistics = new FontAwesome.Sharp.IconButton();
            this.btn_bill = new FontAwesome.Sharp.IconButton();
            this.btn_customer = new FontAwesome.Sharp.IconButton();
            this.btn_staff = new FontAwesome.Sharp.IconButton();
            this.btn_room = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_status = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.cb_type = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.logout = new FontAwesome.Sharp.IconPictureBox();
            this.label_header = new System.Windows.Forms.Label();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.webService1 = new System.Web.Services.WebService();
            this.panel_shadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.sidebar.Controls.Add(this.iconButton1);
            this.sidebar.Controls.Add(this.btn_statistics);
            this.sidebar.Controls.Add(this.btn_bill);
            this.sidebar.Controls.Add(this.btn_customer);
            this.sidebar.Controls.Add(this.btn_staff);
            this.sidebar.Controls.Add(this.btn_room);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(237, 561);
            this.sidebar.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bitbucket;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 365);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(237, 53);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Vật tư";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btn_statistics
            // 
            this.btn_statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_statistics.FlatAppearance.BorderSize = 0;
            this.btn_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_statistics.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btn_statistics.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_statistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_statistics.IconSize = 30;
            this.btn_statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistics.Location = new System.Drawing.Point(0, 312);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_statistics.Size = new System.Drawing.Size(237, 53);
            this.btn_statistics.TabIndex = 7;
            this.btn_statistics.Text = "Thống kê";
            this.btn_statistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_bill.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.btn_bill.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_bill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_bill.IconSize = 30;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(0, 259);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_bill.Size = new System.Drawing.Size(237, 53);
            this.btn_bill.TabIndex = 6;
            this.btn_bill.Text = "Hóa đơn";
            this.btn_bill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_customer.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btn_customer.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customer.IconSize = 30;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(0, 206);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_customer.Size = new System.Drawing.Size(237, 53);
            this.btn_customer.TabIndex = 5;
            this.btn_customer.Text = "Khách hàng";
            this.btn_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_staff.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btn_staff.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_staff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_staff.IconSize = 30;
            this.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.Location = new System.Drawing.Point(0, 153);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_staff.Size = new System.Drawing.Size(237, 53);
            this.btn_staff.TabIndex = 4;
            this.btn_staff.Text = "Nhân viên";
            this.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_room
            // 
            this.btn_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_room.FlatAppearance.BorderSize = 0;
            this.btn_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_room.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_room.IconChar = FontAwesome.Sharp.IconChar.Gg;
            this.btn_room.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_room.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_room.IconSize = 30;
            this.btn_room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_room.Location = new System.Drawing.Point(0, 100);
            this.btn_room.Name = "btn_room";
            this.btn_room.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_room.Size = new System.Drawing.Size(237, 53);
            this.btn_room.TabIndex = 3;
            this.btn_room.Text = "Phòng";
            this.btn_room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_room.UseVisualStyleBackColor = true;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_status);
            this.panel2.Controls.Add(this.cb_type);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.label_header);
            this.panel2.Controls.Add(this.iconCurrentChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 57);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cb_status
            // 
            this.cb_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Phòng VIP",
            "Phòng đơn",
            "Phòng đôi"});
            this.cb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.cb_status.BorderRadius = 14;
            this.cb_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.cb_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_status.FocusedState.Parent = this.cb_status;
            this.cb_status.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cb_status.ForeColor = System.Drawing.Color.White;
            this.cb_status.HoverState.Parent = this.cb_status;
            this.cb_status.ItemHeight = 25;
            this.cb_status.Items.AddRange(new object[] {
            "Tất cả",
            "Còn trống",
            "Đã đặt",
            "Có người",
            "Đang bảo trì"});
            this.cb_status.ItemsAppearance.Parent = this.cb_status;
            this.cb_status.Location = new System.Drawing.Point(574, 20);
            this.cb_status.Name = "cb_status";
            this.cb_status.ShadowDecoration.Parent = this.cb_status;
            this.cb_status.Size = new System.Drawing.Size(150, 31);
            this.cb_status.StartIndex = 0;
            this.cb_status.TabIndex = 12;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // cb_type
            // 
            this.cb_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_type.AutoCompleteCustomSource.AddRange(new string[] {
            "Phòng VIP",
            "Phòng đơn",
            "Phòng đôi"});
            this.cb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.cb_type.BorderRadius = 14;
            this.cb_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.cb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_type.FocusedState.Parent = this.cb_type;
            this.cb_type.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cb_type.ForeColor = System.Drawing.Color.White;
            this.cb_type.HoverState.Parent = this.cb_type;
            this.cb_type.ItemHeight = 25;
            this.cb_type.Items.AddRange(new object[] {
            "Tất cả",
            "Phòng VIP",
            "Phòng đơn",
            "Phòng đôi"});
            this.cb_type.ItemsAppearance.Parent = this.cb_type;
            this.cb_type.Location = new System.Drawing.Point(315, 22);
            this.cb_type.Name = "cb_type";
            this.cb_type.ShadowDecoration.Parent = this.cb_type;
            this.cb_type.Size = new System.Drawing.Size(150, 31);
            this.cb_type.StartIndex = 0;
            this.cb_type.TabIndex = 11;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.siticoneRoundedComboBox1_SelectedIndexChanged);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.logout.IconColor = System.Drawing.Color.Gainsboro;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.Location = new System.Drawing.Point(768, 22);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(32, 32);
            this.logout.TabIndex = 8;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseLeave += new System.EventHandler(this.nothover);
            this.logout.MouseHover += new System.EventHandler(this.hover);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_header.Location = new System.Drawing.Point(56, 20);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(67, 21);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "header";
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.HouseDamage;
            this.iconCurrentChild.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.Location = new System.Drawing.Point(18, 17);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChild.TabIndex = 0;
            this.iconCurrentChild.TabStop = false;
            // 
            // panel_shadow
            // 
            this.panel_shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel_shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_shadow.Location = new System.Drawing.Point(237, 57);
            this.panel_shadow.Name = "panel_shadow";
            this.panel_shadow.Size = new System.Drawing.Size(827, 8);
            this.panel_shadow.TabIndex = 10;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(237, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(827, 496);
            this.panelDesktop.TabIndex = 11;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(254, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(488, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trạng thái";
            // 
            // frHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel_shadow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Close);
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_room;
        private FontAwesome.Sharp.IconButton btn_statistics;
        private FontAwesome.Sharp.IconButton btn_bill;
        private FontAwesome.Sharp.IconButton btn_customer;
        private FontAwesome.Sharp.IconButton btn_staff;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private System.Windows.Forms.Label label_header;
        private FontAwesome.Sharp.IconPictureBox logout;
        private System.Web.Services.WebService webService1;
        private System.Windows.Forms.Panel panel_shadow;
        private System.Windows.Forms.Panel panelDesktop;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cb_type;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}