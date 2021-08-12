
namespace HotelManagement.View
{
    partial class frAddBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddBill));
            this.data_customer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.fir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneGradientButton2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton3 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // data_customer
            // 
            this.data_customer.AllowUserToAddRows = false;
            this.data_customer.AllowUserToOrderColumns = true;
            this.data_customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.data_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.data_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_customer.ColumnHeadersHeight = 40;
            this.data_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fir,
            this.Column1,
            this.Column2,
            this.Column3,
            this.total_item,
            this.iden,
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_customer.DoubleBuffered = true;
            this.data_customer.EnableHeadersVisualStyles = false;
            this.data_customer.GridColor = System.Drawing.Color.White;
            this.data_customer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.data_customer.HeaderForeColor = System.Drawing.Color.Black;
            this.data_customer.Location = new System.Drawing.Point(45, 132);
            this.data_customer.Name = "data_customer";
            this.data_customer.ReadOnly = true;
            this.data_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data_customer.RowHeadersVisible = false;
            this.data_customer.RowHeadersWidth = 50;
            this.data_customer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.data_customer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.data_customer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.data_customer.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_customer.RowTemplate.Height = 30;
            this.data_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_customer.Size = new System.Drawing.Size(1208, 276);
            this.data_customer.TabIndex = 92;
            this.data_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDetailCustomer);
            // 
            // fir
            // 
            this.fir.HeaderText = "Họ";
            this.fir.Name = "fir";
            this.fir.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // total_item
            // 
            this.total_item.HeaderText = "Số điện thoại";
            this.total_item.Name = "total_item";
            this.total_item.ReadOnly = true;
            // 
            // iden
            // 
            this.iden.HeaderText = "Số chứng minh nhân dân";
            this.iden.Name = "iden";
            this.iden.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txt_search.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txt_search.HintText = "";
            this.txt_search.isPassword = false;
            this.txt_search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txt_search.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txt_search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txt_search.LineThickness = 1;
            this.txt_search.Location = new System.Drawing.Point(811, 71);
            this.txt_search.Margin = new System.Windows.Forms.Padding(0);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(232, 33);
            this.txt_search.TabIndex = 94;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(573, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "TẠO PHÒNG";
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.siticoneGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(22)))), ((int)(((byte)(140)))));
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton2.HoverState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Image = global::HotelManagement.Properties.Resources.cl;
            this.siticoneGradientButton2.ImageSize = new System.Drawing.Size(28, 24);
            this.siticoneGradientButton2.Location = new System.Drawing.Point(709, 469);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton2.TabIndex = 101;
            this.siticoneGradientButton2.Text = "Hủy";
            this.siticoneGradientButton2.Click += new System.EventHandler(this.siticoneGradientButton2_Click);
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.HoverState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Image = global::HotelManagement.Properties.Resources.plusss;
            this.siticoneGradientButton1.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton1.Location = new System.Drawing.Point(385, 469);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneGradientButton1.TabIndex = 100;
            this.siticoneGradientButton1.Text = "Thêm";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
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
            this.siticoneGradientButton3.Location = new System.Drawing.Point(1073, 61);
            this.siticoneGradientButton3.Name = "siticoneGradientButton3";
            this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Size = new System.Drawing.Size(180, 43);
            this.siticoneGradientButton3.TabIndex = 108;
            this.siticoneGradientButton3.Text = "Tìm kiếm";
            this.siticoneGradientButton3.Click += new System.EventHandler(this.siticoneGradientButton3_Click);
            // 
            // frAddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1300, 606);
            this.Controls.Add(this.siticoneGradientButton3);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.data_customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frAddBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo phòng";
            this.Load += new System.EventHandler(this.frAddBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid data_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn fir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn iden;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;
    }
}