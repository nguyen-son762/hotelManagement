
namespace HotelManagement.View
{
    partial class frStatisticalManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frStatisticalManager));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_begin = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.year = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.cb_end = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.siticoneGradientButton1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(122, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(512, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Năm";
            // 
            // cb_begin
            // 
            this.cb_begin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_begin.BackColor = System.Drawing.Color.Transparent;
            this.cb_begin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cb_begin.BorderRadius = 12;
            this.cb_begin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_begin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_begin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cb_begin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_begin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_begin.FocusedState.Parent = this.cb_begin;
            this.cb_begin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_begin.ForeColor = System.Drawing.Color.White;
            this.cb_begin.HoverState.Parent = this.cb_begin;
            this.cb_begin.ItemHeight = 20;
            this.cb_begin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_begin.ItemsAppearance.Parent = this.cb_begin;
            this.cb_begin.Location = new System.Drawing.Point(176, 87);
            this.cb_begin.Name = "cb_begin";
            this.cb_begin.ShadowDecoration.Parent = this.cb_begin;
            this.cb_begin.Size = new System.Drawing.Size(66, 26);
            this.cb_begin.StartIndex = 0;
            this.cb_begin.TabIndex = 35;
            // 
            // year
            // 
            this.year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.year.BorderRadius = 12;
            this.year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.year.FocusedState.Parent = this.year;
            this.year.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.year.ForeColor = System.Drawing.Color.White;
            this.year.HoverState.Parent = this.year;
            this.year.ItemHeight = 20;
            this.year.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.year.ItemsAppearance.Parent = this.year;
            this.year.Location = new System.Drawing.Point(585, 89);
            this.year.Name = "year";
            this.year.ShadowDecoration.Parent = this.year;
            this.year.Size = new System.Drawing.Size(87, 26);
            this.year.StartIndex = 0;
            this.year.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(239, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tổng tiền:";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.lb_total.Location = new System.Drawing.Point(370, 286);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(0, 29);
            this.lb_total.TabIndex = 39;
            // 
            // cb_end
            // 
            this.cb_end.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_end.BackColor = System.Drawing.Color.Transparent;
            this.cb_end.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cb_end.BorderRadius = 12;
            this.cb_end.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_end.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.cb_end.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_end.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_end.FocusedState.Parent = this.cb_end;
            this.cb_end.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_end.ForeColor = System.Drawing.Color.White;
            this.cb_end.HoverState.Parent = this.cb_end;
            this.cb_end.ItemHeight = 20;
            this.cb_end.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_end.ItemsAppearance.Parent = this.cb_end;
            this.cb_end.Location = new System.Drawing.Point(359, 87);
            this.cb_end.Name = "cb_end";
            this.cb_end.ShadowDecoration.Parent = this.cb_end;
            this.cb_end.Size = new System.Drawing.Size(66, 26);
            this.cb_end.StartIndex = 0;
            this.cb_end.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(289, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Đến";
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
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(163)))), ((int)(((byte)(251)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneGradientButton1.HoverState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Image = global::HotelManagement.Properties.Resources.download__1_;
            this.siticoneGradientButton1.ImageOffset = new System.Drawing.Point(-5, 0);
            this.siticoneGradientButton1.ImageSize = new System.Drawing.Size(28, 22);
            this.siticoneGradientButton1.Location = new System.Drawing.Point(492, 161);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(180, 43);
            this.siticoneGradientButton1.TabIndex = 107;
            this.siticoneGradientButton1.Text = "Tìm kiếm";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // frStatisticalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(971, 501);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.cb_end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year);
            this.Controls.Add(this.cb_begin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frStatisticalManager";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frStatisticalManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cb_begin;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_total;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cb_end;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}