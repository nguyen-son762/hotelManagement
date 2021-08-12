
namespace HotelManagement.View
{
    partial class frStaffManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frStaffManager));
            this.data_staff = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_position = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.siticoneGradientButton3 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // data_staff
            // 
            this.data_staff.AllowDrop = true;
            this.data_staff.AllowUserToAddRows = false;
            this.data_staff.AllowUserToOrderColumns = true;
            this.data_staff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.data_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_staff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.data_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_staff.ColumnHeadersHeight = 30;
            this.data_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_staff.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_staff.DoubleBuffered = true;
            this.data_staff.EnableHeadersVisualStyles = false;
            this.data_staff.GridColor = System.Drawing.Color.White;
            this.data_staff.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.data_staff.HeaderForeColor = System.Drawing.Color.White;
            this.data_staff.Location = new System.Drawing.Point(53, 319);
            this.data_staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_staff.Name = "data_staff";
            this.data_staff.ReadOnly = true;
            this.data_staff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_staff.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_staff.RowHeadersVisible = false;
            this.data_staff.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.data_staff.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data_staff.RowTemplate.Height = 30;
            this.data_staff.RowTemplate.ReadOnly = true;
            this.data_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_staff.ShowCellErrors = false;
            this.data_staff.ShowRowErrors = false;
            this.data_staff.Size = new System.Drawing.Size(1089, 296);
            this.data_staff.TabIndex = 20;
            this.data_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vị trí làm việc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(74, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Vị trí làm việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(466, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(466, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "NHÂN VIÊN";
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_name.HintForeColor = System.Drawing.Color.White;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_name.LineThickness = 2;
            this.txt_name.Location = new System.Drawing.Point(177, 76);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 33);
            this.txt_name.TabIndex = 31;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_position
            // 
            this.txt_position.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_position.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_position.HintForeColor = System.Drawing.Color.White;
            this.txt_position.HintText = "";
            this.txt_position.isPassword = false;
            this.txt_position.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_position.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_position.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_position.LineThickness = 2;
            this.txt_position.Location = new System.Drawing.Point(177, 168);
            this.txt_position.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(207, 33);
            this.txt_position.TabIndex = 32;
            this.txt_position.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_address
            // 
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_address.HintForeColor = System.Drawing.Color.White;
            this.txt_address.HintText = "";
            this.txt_address.isPassword = false;
            this.txt_address.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_address.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_address.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txt_address.LineThickness = 2;
            this.txt_address.Location = new System.Drawing.Point(532, 69);
            this.txt_address.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(417, 33);
            this.txt_address.TabIndex = 33;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.siticoneGradientButton3.Location = new System.Drawing.Point(253, 258);
            this.siticoneGradientButton3.Name = "siticoneGradientButton3";
            this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton3.TabIndex = 108;
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
            this.siticoneGradientButton2.Location = new System.Drawing.Point(53, 260);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton2.TabIndex = 107;
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
            this.siticoneGradientButton1.Location = new System.Drawing.Point(962, 260);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 43);
            this.siticoneGradientButton1.TabIndex = 106;
            this.siticoneGradientButton1.Text = "Xóa";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // frStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1200, 644);
            this.Controls.Add(this.siticoneGradientButton3);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_staff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frStaffManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frStaffManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid data_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_position;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_address;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}