
namespace HotelManagement.View
{
    partial class frBillManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_bill = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.begin_date = new Siticone.Desktop.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.end_date = new Siticone.Desktop.UI.WinForms.SiticoneRoundedDateTimePicker();
            this.siticoneGradientButton2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton3 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.IDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // data_bill
            // 
            this.data_bill.AllowUserToAddRows = false;
            this.data_bill.AllowUserToOrderColumns = true;
            this.data_bill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.data_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_bill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_bill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.data_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_bill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_bill.ColumnHeadersHeight = 30;
            this.data_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBill,
            this.Room,
            this.Name,
            this.Checkin,
            this.Checkout,
            this.statusBill,
            this.Created,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_bill.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_bill.DoubleBuffered = true;
            this.data_bill.EnableHeadersVisualStyles = false;
            this.data_bill.GridColor = System.Drawing.Color.White;
            this.data_bill.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.data_bill.HeaderForeColor = System.Drawing.Color.White;
            this.data_bill.Location = new System.Drawing.Point(60, 232);
            this.data_bill.Name = "data_bill";
            this.data_bill.ReadOnly = true;
            this.data_bill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_bill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_bill.RowHeadersVisible = false;
            this.data_bill.RowHeadersWidth = 50;
            this.data_bill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.data_bill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.data_bill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.data_bill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.data_bill.RowTemplate.Height = 30;
            this.data_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_bill.Size = new System.Drawing.Size(925, 276);
            this.data_bill.TabIndex = 92;
            this.data_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show);
            this.data_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_bill_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.Parent = this.txt_id;
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedState.Parent = this.txt_id;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.HoverState.Parent = this.txt_id;
            this.txt_id.Location = new System.Drawing.Point(97, 98);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.ShadowDecoration.Parent = this.txt_id;
            this.txt_id.Size = new System.Drawing.Size(200, 30);
            this.txt_id.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(361, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Từ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(565, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Đến";
            // 
            // begin_date
            // 
            this.begin_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.begin_date.BorderRadius = 15;
            this.begin_date.CheckedState.Parent = this.begin_date;
            this.begin_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.begin_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.begin_date.HoverState.Parent = this.begin_date;
            this.begin_date.Location = new System.Drawing.Point(394, 98);
            this.begin_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.begin_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.begin_date.Name = "begin_date";
            this.begin_date.ShadowDecoration.Parent = this.begin_date;
            this.begin_date.Size = new System.Drawing.Size(165, 33);
            this.begin_date.TabIndex = 104;
            this.begin_date.Value = new System.DateTime(2021, 7, 16, 22, 37, 41, 528);
            // 
            // end_date
            // 
            this.end_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.end_date.BorderRadius = 15;
            this.end_date.CheckedState.Parent = this.end_date;
            this.end_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.HoverState.Parent = this.end_date;
            this.end_date.Location = new System.Drawing.Point(625, 98);
            this.end_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.end_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.end_date.Name = "end_date";
            this.end_date.ShadowDecoration.Parent = this.end_date;
            this.end_date.Size = new System.Drawing.Size(165, 33);
            this.end_date.TabIndex = 105;
            this.end_date.Value = new System.DateTime(2021, 7, 16, 22, 37, 41, 528);
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneGradientButton2.Animated = true;
            this.siticoneGradientButton2.BorderRadius = 8;
            this.siticoneGradientButton2.CheckedState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneGradientButton2.CustomImages.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton2.DisabledState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(236)))), ((int)(((byte)(33)))));
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.HoverState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Image = global::HotelManagement.Properties.Resources.export;
            this.siticoneGradientButton2.ImageOffset = new System.Drawing.Point(-5, 0);
            this.siticoneGradientButton2.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton2.Location = new System.Drawing.Point(852, 12);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(143, 43);
            this.siticoneGradientButton2.TabIndex = 110;
            this.siticoneGradientButton2.Text = "Xuất Excel";
            this.siticoneGradientButton2.Click += new System.EventHandler(this.siticoneGradientButton2_Click);
            // 
            // siticoneGradientButton3
            // 
            this.siticoneGradientButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneGradientButton3.Animated = true;
            this.siticoneGradientButton3.BorderRadius = 8;
            this.siticoneGradientButton3.CheckedState.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneGradientButton3.CustomImages.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton3.DisabledState.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(163)))), ((int)(((byte)(251)))));
            this.siticoneGradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.siticoneGradientButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.siticoneGradientButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.HoverState.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Image = global::HotelManagement.Properties.Resources.download__1_;
            this.siticoneGradientButton3.ImageOffset = new System.Drawing.Point(-5, 0);
            this.siticoneGradientButton3.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton3.Location = new System.Drawing.Point(815, 88);
            this.siticoneGradientButton3.Name = "siticoneGradientButton3";
            this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Size = new System.Drawing.Size(180, 43);
            this.siticoneGradientButton3.TabIndex = 109;
            this.siticoneGradientButton3.Text = "Tìm kiếm";
            this.siticoneGradientButton3.Click += new System.EventHandler(this.siticoneGradientButton3_Click);
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneGradientButton1.Animated = true;
            this.siticoneGradientButton1.BorderRadius = 8;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneGradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneGradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneGradientButton1.DisabledState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(32)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(131)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.HoverState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Image = global::HotelManagement.Properties.Resources.delete1;
            this.siticoneGradientButton1.ImageOffset = new System.Drawing.Point(-5, 0);
            this.siticoneGradientButton1.ImageSize = new System.Drawing.Size(27, 22);
            this.siticoneGradientButton1.Location = new System.Drawing.Point(805, 544);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 43);
            this.siticoneGradientButton1.TabIndex = 99;
            this.siticoneGradientButton1.Text = "Xóa";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click_1);
            // 
            // IDBill
            // 
            this.IDBill.DataPropertyName = "ID";
            this.IDBill.HeaderText = "ID";
            this.IDBill.Name = "IDBill";
            this.IDBill.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Phòng";
            this.Room.HeaderText = "Phòng";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Họ tên";
            this.Name.HeaderText = "Họ tên";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.DataPropertyName = "Ngày đến";
            this.Checkin.HeaderText = "Ngày đến";
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.DataPropertyName = "Ngày đi";
            this.Checkout.HeaderText = "Ngày đi";
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // statusBill
            // 
            this.statusBill.HeaderText = "Trạng thái";
            this.statusBill.Name = "statusBill";
            this.statusBill.ReadOnly = true;
            // 
            // Created
            // 
            this.Created.HeaderText = "Ngày tạo";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Tổng tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // frBillManager
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1041, 612);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton3);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.begin_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.data_bill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = " 10";
            this.Load += new System.EventHandler(this.frBillManager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.data_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid data_bill;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedDateTimePicker begin_date;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedDateTimePicker end_date;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}