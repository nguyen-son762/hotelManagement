
namespace HotelManagement.View
{
    partial class frRoomManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frRoomManager));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_type = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.data_service = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_status = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.webService1 = new System.Web.Services.WebService();
            this.siticoneGradientButton3 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_service)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng:";
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_name.HintForeColor = System.Drawing.Color.White;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_name.LineThickness = 2;
            this.txt_name.Location = new System.Drawing.Point(108, 41);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(133, 38);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.OnValueChanged += new System.EventHandler(this.txt_name_OnValueChanged);
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_price.HintForeColor = System.Drawing.Color.White;
            this.txt_price.HintText = "";
            this.txt_price.isPassword = false;
            this.txt_price.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_price.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_price.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_price.LineThickness = 2;
            this.txt_price.Location = new System.Drawing.Point(108, 94);
            this.txt_price.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(133, 39);
            this.txt_price.TabIndex = 3;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_price.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(276, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại phòng:";
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.Transparent;
            this.cb_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cb_type.BorderRadius = 14;
            this.cb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.cb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_type.FocusedState.Parent = this.cb_type;
            this.cb_type.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cb_type.HoverState.Parent = this.cb_type;
            this.cb_type.ItemHeight = 25;
            this.cb_type.Items.AddRange(new object[] {
            "Phòng VIP",
            "Phòng đơn",
            "Phòng đôi"});
            this.cb_type.ItemsAppearance.Parent = this.cb_type;
            this.cb_type.Location = new System.Drawing.Point(381, 47);
            this.cb_type.Name = "cb_type";
            this.cb_type.ShadowDecoration.Parent = this.cb_type;
            this.cb_type.Size = new System.Drawing.Size(159, 31);
            this.cb_type.StartIndex = 0;
            this.cb_type.TabIndex = 5;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.siticoneRoundedComboBox1_SelectedIndexChanged);
            // 
            // data_service
            // 
            this.data_service.AllowDrop = true;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_service.ColumnHeadersHeight = 30;
            this.data_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_service.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.data_service.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.data_service.HeaderForeColor = System.Drawing.Color.White;
            this.data_service.Location = new System.Drawing.Point(43, 141);
            this.data_service.Name = "data_service";
            this.data_service.ReadOnly = true;
            this.data_service.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_service.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_service.RowHeadersVisible = false;
            this.data_service.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.data_service.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data_service.RowTemplate.Height = 30;
            this.data_service.RowTemplate.ReadOnly = true;
            this.data_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_service.ShowCellErrors = false;
            this.data_service.ShowRowErrors = false;
            this.data_service.Size = new System.Drawing.Size(782, 251);
            this.data_service.TabIndex = 19;
            this.data_service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getDetailRoom);
            this.data_service.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_service_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên phòng";
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
            this.Column3.HeaderText = "Loại phòng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_id.HintForeColor = System.Drawing.Color.Empty;
            this.txt_id.HintText = "";
            this.txt_id.isPassword = false;
            this.txt_id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_id.LineIdleColor = System.Drawing.Color.Transparent;
            this.txt_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.txt_id.LineThickness = 2;
            this.txt_id.Location = new System.Drawing.Point(381, 88);
            this.txt_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(96, 38);
            this.txt_id.TabIndex = 22;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(276, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID:";
            // 
            // cb_status
            // 
            this.cb_status.BackColor = System.Drawing.Color.Transparent;
            this.cb_status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cb_status.BorderRadius = 14;
            this.cb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.cb_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_status.FocusedState.Parent = this.cb_status;
            this.cb_status.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cb_status.HoverState.Parent = this.cb_status;
            this.cb_status.ItemHeight = 25;
            this.cb_status.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đặt",
            "Có người",
            "Đang bảo trì"});
            this.cb_status.ItemsAppearance.Parent = this.cb_status;
            this.cb_status.Location = new System.Drawing.Point(666, 50);
            this.cb_status.Name = "cb_status";
            this.cb_status.ShadowDecoration.Parent = this.cb_status;
            this.cb_status.Size = new System.Drawing.Size(159, 31);
            this.cb_status.StartIndex = 0;
            this.cb_status.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(561, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Trạng thái:";
            // 
            // siticoneGradientButton3
            // 
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
            this.siticoneGradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(220)))));
            this.siticoneGradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(63)))));
            this.siticoneGradientButton3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.siticoneGradientButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton3.HoverState.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Image = global::HotelManagement.Properties.Resources.download;
            this.siticoneGradientButton3.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton3.Location = new System.Drawing.Point(249, 430);
            this.siticoneGradientButton3.Name = "siticoneGradientButton3";
            this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton3.TabIndex = 105;
            this.siticoneGradientButton3.Text = "Sửa";
            this.siticoneGradientButton3.Click += new System.EventHandler(this.siticoneGradientButton3_Click);
            // 
            // siticoneGradientButton2
            // 
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
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.HoverState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Image = global::HotelManagement.Properties.Resources.plusss;
            this.siticoneGradientButton2.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton2.Location = new System.Drawing.Point(43, 430);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton2.TabIndex = 104;
            this.siticoneGradientButton2.Text = "Thêm";
            this.siticoneGradientButton2.Click += new System.EventHandler(this.siticoneGradientButton2_Click);
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
            this.siticoneGradientButton1.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton1.Location = new System.Drawing.Point(645, 430);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 43);
            this.siticoneGradientButton1.TabIndex = 103;
            this.siticoneGradientButton1.Text = "Xóa";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // frRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(889, 510);
            this.Controls.Add(this.siticoneGradientButton3);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_service);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frRoomManager";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frRoomManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cb_type;
        private Bunifu.Framework.UI.BunifuCustomDataGrid data_service;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cb_status;
        private System.Windows.Forms.Label label5;
        private System.Web.Services.WebService webService1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}