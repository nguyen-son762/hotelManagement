using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frHome : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private RoomBusiness roomBusiness;
        public frHome()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 53);
            sidebar.Controls.Add(leftBorderBtn);
            label_header.Text = "Khách sạn";
            label_header.ForeColor = Color.FromArgb(30, 144, 255);
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.FromArgb(30, 144, 255);
            roomBusiness = new RoomBusiness();
            LoadData();
        }
        //dark title bar
        private void Home_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void form_Close(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 242, 0);
            public static Color color2 = Color.FromArgb(46, 213, 115);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(235, 77, 75);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color colorItem = Color.FromArgb(224, 86, 253);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChild.IconChar = currentBtn.IconChar;
                iconCurrentChild.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            label_header.Text = "Phòng";
            label_header.ForeColor = RGBColors.color2;
            frRoomManager fr = new frRoomManager();
            OpenChildForm(fr);
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            label_header.Text = "Nhân viên";
            label_header.ForeColor = RGBColors.color3;
            OpenChildForm(new frStaffManager());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            label_header.Text = "Khách hàng";
            label_header.ForeColor = RGBColors.color1;
            OpenChildForm(new frCustomerManager());
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            label_header.Text = "Hóa đơn";
            label_header.ForeColor = RGBColors.color5;
            OpenChildForm(new frBillManager());
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            label_header.Text = "Thống kê";
            label_header.ForeColor = RGBColors.color6;
            OpenChildForm(new frStatisticalManager());
        }

        private void hover(object sender, EventArgs e)
        {
            logout.IconColor = Color.FromArgb(249, 118, 176);
        }

        private void nothover(object sender, EventArgs e)
        {
            logout.IconColor = Color.Gainsboro;
        }
        //Drag Form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label_header.Text = "Khách sạn";
            label_header.ForeColor = Color.FromArgb(30, 144, 255);
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.FromArgb(30, 144, 255);
            LoadData();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchRoom();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchRoom();
        }
        private void searchRoom()
        {
            string type = "";
            string status = "";
            if (cb_type.Text != "Tất cả")
            {
                type = cb_type.Text;
            }
            if (cb_status.Text != "Tất cả")
            {
                status = cb_status.Text;
            }
            List<Room> rooms = roomBusiness.getRoomsByTypeAndStatus(type, status);
            OpenChildForm(new frRoom(rooms));
        }
        private void LoadData()
        {
            List<Room> rooms = roomBusiness.getAllRooms();
            frRoom fr = new frRoom(rooms, SetValue);
            OpenChildForm(fr);
        }

        private void SetValue()
        {
            LoadData();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorItem);
            label_header.Text = "Vật tư";
            label_header.ForeColor = RGBColors.colorItem;
            OpenChildForm(new frItemManager());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorItem);
            label_header.Text = "Vật tư";
            label_header.ForeColor = RGBColors.colorItem;
            OpenChildForm(new frItemManager());
        }
    }
}
