
namespace HotelManagement.View
{
    partial class frRoomDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frRoomDetail));
            this.customerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkout = new Bunifu.Framework.UI.BunifuDatepicker();
            this.checkin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.roomStatus = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomType = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_service = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nameService = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_pay = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btn_fix = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btn_add = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btn_delete = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btn_booking = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_createBill = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.data_service)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.customerName.HintForeColor = System.Drawing.Color.White;
            this.customerName.HintText = "";
            this.customerName.isPassword = false;
            this.customerName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.customerName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.customerName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.customerName.LineThickness = 1;
            this.customerName.Location = new System.Drawing.Point(590, 73);
            this.customerName.Margin = new System.Windows.Forms.Padding(0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(232, 33);
            this.customerName.TabIndex = 75;
            this.customerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label11.Location = new System.Drawing.Point(446, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 21);
            this.label11.TabIndex = 74;
            this.label11.Text = "Tên khách hàng:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txt_quantity.HintForeColor = System.Drawing.Color.White;
            this.txt_quantity.HintText = "";
            this.txt_quantity.isPassword = false;
            this.txt_quantity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txt_quantity.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.txt_quantity.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txt_quantity.LineThickness = 1;
            this.txt_quantity.Location = new System.Drawing.Point(911, 139);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(0);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(111, 33);
            this.txt_quantity.TabIndex = 72;
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label10.Location = new System.Drawing.Point(832, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 71;
            this.label10.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(446, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Tên dịch vụ:";
            // 
            // lb_total
            // 
            this.lb_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.White;
            this.lb_total.Location = new System.Drawing.Point(1163, 458);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(32, 24);
            this.lb_total.TabIndex = 66;
            this.lb_total.Text = "0đ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1052, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(28, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ngày đi:";
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.checkout.BorderRadius = 0;
            this.checkout.ForeColor = System.Drawing.Color.White;
            this.checkout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkout.FormatCustom = null;
            this.checkout.Location = new System.Drawing.Point(121, 305);
            this.checkout.Margin = new System.Windows.Forms.Padding(8);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(271, 26);
            this.checkout.TabIndex = 63;
            this.checkout.Value = new System.DateTime(2021, 7, 2, 15, 25, 33, 863);
            this.checkout.onValueChanged += new System.EventHandler(this.change_end);
            // 
            // checkin
            // 
            this.checkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.checkin.BorderRadius = 0;
            this.checkin.ForeColor = System.Drawing.Color.White;
            this.checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkin.FormatCustom = null;
            this.checkin.Location = new System.Drawing.Point(121, 258);
            this.checkin.Margin = new System.Windows.Forms.Padding(5);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(271, 24);
            this.checkin.TabIndex = 62;
            this.checkin.Value = new System.DateTime(2021, 7, 2, 15, 25, 33, 863);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(28, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ngày đến:";
            // 
            // roomStatus
            // 
            this.roomStatus.BackColor = System.Drawing.Color.Transparent;
            this.roomStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomStatus.BorderRadius = 12;
            this.roomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.roomStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomStatus.FocusedState.Parent = this.roomStatus;
            this.roomStatus.Font = new System.Drawing.Font("Century", 12F);
            this.roomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomStatus.HoverState.Parent = this.roomStatus;
            this.roomStatus.ItemHeight = 20;
            this.roomStatus.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt",
            "Có người",
            "Đang bảo trì"});
            this.roomStatus.ItemsAppearance.Parent = this.roomStatus;
            this.roomStatus.Location = new System.Drawing.Point(126, 211);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.ShadowDecoration.Parent = this.roomStatus;
            this.roomStatus.Size = new System.Drawing.Size(152, 26);
            this.roomStatus.StartIndex = 0;
            this.roomStatus.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(28, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "Trạng thái:";
            // 
            // roomPrice
            // 
            this.roomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomPrice.HintForeColor = System.Drawing.Color.White;
            this.roomPrice.HintText = "";
            this.roomPrice.isPassword = false;
            this.roomPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.roomPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomPrice.LineThickness = 1;
            this.roomPrice.Location = new System.Drawing.Point(129, 160);
            this.roomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(111, 33);
            this.roomPrice.TabIndex = 57;
            this.roomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Giá phòng:";
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.Color.Transparent;
            this.roomType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomType.BorderRadius = 12;
            this.roomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.roomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType.FocusedState.Parent = this.roomType;
            this.roomType.Font = new System.Drawing.Font("Century", 12F);
            this.roomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomType.HoverState.Parent = this.roomType;
            this.roomType.ItemHeight = 20;
            this.roomType.Items.AddRange(new object[] {
            "Phòng VIP",
            "Phòng đơn",
            "Phòng đôi"});
            this.roomType.ItemsAppearance.Parent = this.roomType;
            this.roomType.Location = new System.Drawing.Point(128, 123);
            this.roomType.Name = "roomType";
            this.roomType.ShadowDecoration.Parent = this.roomType;
            this.roomType.Size = new System.Drawing.Size(152, 26);
            this.roomType.StartIndex = 0;
            this.roomType.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Loại phòng:";
            // 
            // roomName
            // 
            this.roomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomName.HintForeColor = System.Drawing.Color.White;
            this.roomName.HintText = "";
            this.roomName.isPassword = false;
            this.roomName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.roomName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.roomName.LineThickness = 1;
            this.roomName.Location = new System.Drawing.Point(127, 69);
            this.roomName.Margin = new System.Windows.Forms.Padding(0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(128, 33);
            this.roomName.TabIndex = 53;
            this.roomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tên phòng:";
            // 
            // data_service
            // 
            this.data_service.AllowUserToAddRows = false;
            this.data_service.AllowUserToOrderColumns = true;
            this.data_service.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.data_service.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_service.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.data_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_service.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_service.ColumnHeadersHeight = 30;
            this.data_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.total_item,
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_service.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_service.DoubleBuffered = true;
            this.data_service.EnableHeadersVisualStyles = false;
            this.data_service.GridColor = System.Drawing.Color.White;
            this.data_service.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.data_service.HeaderForeColor = System.Drawing.Color.White;
            this.data_service.Location = new System.Drawing.Point(444, 200);
            this.data_service.Name = "data_service";
            this.data_service.ReadOnly = true;
            this.data_service.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_service.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_service.RowHeadersVisible = false;
            this.data_service.RowHeadersWidth = 50;
            this.data_service.RowTemplate.Height = 30;
            this.data_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_service.Size = new System.Drawing.Size(821, 222);
            this.data_service.TabIndex = 76;
            this.data_service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDetailService);
            this.data_service.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_service_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên dịch vụ:";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // total_item
            // 
            this.total_item.HeaderText = "Thành tiền";
            this.total_item.Name = "total_item";
            this.total_item.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // txt_nameService
            // 
            this.txt_nameService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nameService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txt_nameService.HintForeColor = System.Drawing.Color.White;
            this.txt_nameService.HintText = "";
            this.txt_nameService.isPassword = false;
            this.txt_nameService.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txt_nameService.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.txt_nameService.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txt_nameService.LineThickness = 1;
            this.txt_nameService.Location = new System.Drawing.Point(541, 139);
            this.txt_nameService.Margin = new System.Windows.Forms.Padding(0);
            this.txt_nameService.Name = "txt_nameService";
            this.txt_nameService.Size = new System.Drawing.Size(263, 33);
            this.txt_nameService.TabIndex = 73;
            this.txt_nameService.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_pay
            // 
            this.btn_pay.Animated = true;
            this.btn_pay.BorderRadius = 8;
            this.btn_pay.CheckedState.Parent = this.btn_pay;
            this.btn_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pay.CustomImages.Parent = this.btn_pay;
            this.btn_pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pay.DisabledState.Parent = this.btn_pay;
            this.btn_pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.btn_pay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(174)))));
            this.btn_pay.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.HoverState.Parent = this.btn_pay;
            this.btn_pay.Image = global::HotelManagement.Properties.Resources.bill;
            this.btn_pay.ImageSize = new System.Drawing.Size(28, 22);
            this.btn_pay.Location = new System.Drawing.Point(250, 385);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.ShadowDecoration.Parent = this.btn_pay;
            this.btn_pay.Size = new System.Drawing.Size(142, 79);
            this.btn_pay.TabIndex = 106;
            this.btn_pay.Text = "Trả phòng";
            this.btn_pay.Click += new System.EventHandler(this.siticoneGradientButton1_Click_1);
            // 
            // btn_fix
            // 
            this.btn_fix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fix.Animated = true;
            this.btn_fix.BorderRadius = 8;
            this.btn_fix.CheckedState.Parent = this.btn_fix;
            this.btn_fix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fix.CustomImages.Parent = this.btn_fix;
            this.btn_fix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fix.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fix.DisabledState.Parent = this.btn_fix;
            this.btn_fix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(220)))));
            this.btn_fix.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(63)))));
            this.btn_fix.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_fix.ForeColor = System.Drawing.Color.White;
            this.btn_fix.HoverState.Parent = this.btn_fix;
            this.btn_fix.Image = global::HotelManagement.Properties.Resources.download;
            this.btn_fix.ImageSize = new System.Drawing.Size(28, 22);
            this.btn_fix.Location = new System.Drawing.Point(875, 514);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.ShadowDecoration.Parent = this.btn_fix;
            this.btn_fix.Size = new System.Drawing.Size(180, 45);
            this.btn_fix.TabIndex = 105;
            this.btn_fix.Text = "Sửa";
            this.btn_fix.Click += new System.EventHandler(this.siticoneGradientButton3_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Animated = true;
            this.btn_add.BorderRadius = 8;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.DisabledState.Parent = this.btn_add;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = global::HotelManagement.Properties.Resources.plusss;
            this.btn_add.ImageSize = new System.Drawing.Size(28, 22);
            this.btn_add.Location = new System.Drawing.Point(657, 514);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(180, 45);
            this.btn_add.TabIndex = 104;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.siticoneGradientButton2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Animated = true;
            this.btn_delete.BorderRadius = 8;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.DisabledState.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(32)))));
            this.btn_delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(131)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Image = global::HotelManagement.Properties.Resources.delete1;
            this.btn_delete.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_delete.ImageSize = new System.Drawing.Size(28, 22);
            this.btn_delete.Location = new System.Drawing.Point(1085, 516);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(180, 43);
            this.btn_delete.TabIndex = 103;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.ActiveBorderThickness = 1;
            this.btn_booking.ActiveCornerRadius = 20;
            this.btn_booking.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_booking.ActiveForecolor = System.Drawing.Color.White;
            this.btn_booking.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_booking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_booking.BackgroundImage")));
            this.btn_booking.ButtonText = "Đặt trước";
            this.btn_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_booking.IdleBorderThickness = 1;
            this.btn_booking.IdleCornerRadius = 20;
            this.btn_booking.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_booking.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_booking.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_booking.Location = new System.Drawing.Point(41, 493);
            this.btn_booking.Margin = new System.Windows.Forms.Padding(5);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(117, 82);
            this.btn_booking.TabIndex = 78;
            this.btn_booking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_createBill
            // 
            this.btn_createBill.ActiveBorderThickness = 1;
            this.btn_createBill.ActiveCornerRadius = 20;
            this.btn_createBill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_createBill.ActiveForecolor = System.Drawing.Color.White;
            this.btn_createBill.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_createBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_createBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_createBill.BackgroundImage")));
            this.btn_createBill.ButtonText = "Tạo hóa đơn";
            this.btn_createBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_createBill.IdleBorderThickness = 1;
            this.btn_createBill.IdleCornerRadius = 20;
            this.btn_createBill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_createBill.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_createBill.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_createBill.Location = new System.Drawing.Point(41, 381);
            this.btn_createBill.Margin = new System.Windows.Forms.Padding(5);
            this.btn_createBill.Name = "btn_createBill";
            this.btn_createBill.Size = new System.Drawing.Size(117, 83);
            this.btn_createBill.TabIndex = 69;
            this.btn_createBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_createBill.Click += new System.EventHandler(this.btn_createBill_Click);
            // 
            // frRoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1292, 623);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.data_service);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_nameService);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_createBill);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.label1);
            this.Name = "frRoomDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox customerName;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_createBill;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker checkout;
        private Bunifu.Framework.UI.BunifuDatepicker checkin;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox roomStatus;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomPrice;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox roomType;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid data_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nameService;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_booking;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btn_fix;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btn_add;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btn_delete;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btn_pay;
    }
}