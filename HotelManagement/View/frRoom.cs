using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DAO;
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frRoom : Form
    {
        private RoomBusiness roomBusiness;
        private List<Room> rooms;
        public delegate void SendMessage();
        public SendMessage send;
        public frRoom(List<Room> room)
        {

            InitializeComponent();
            roomBusiness = new RoomBusiness();
            this.rooms = room;
        }
        public frRoom(List<Room> room,SendMessage sender)
        {

            InitializeComponent();
            roomBusiness = new RoomBusiness();
            this.rooms = room;
            this.send = sender;
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void detailRoom(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id =Int32.Parse(button.Tag.ToString());
            frRoomDetail detail = new frRoomDetail(id);
            detail.ShowDialog();
            if (detail.DialogResult == DialogResult.OK)
            {
                this.send();
            }
        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_container_Paint_1(object sender, PaintEventArgs e)
        {
        }
        private void show(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            foreach (var room in rooms)
            {
                Panel panel_item = new Panel();
                Button btn_title = new Button();
                Button btn_content = new Button();
                Button btn_status = new Button();
                panel_item.Controls.Add(btn_content);
                panel_item.Controls.Add(btn_title);
                panel_item.Controls.Add(btn_status);
                btn_title.Cursor = Cursors.Hand;
                btn_content.Cursor = Cursors.Hand;
                panel_item.Width = 200;
                panel_item.Height = 230;
                //title
                btn_title.Text = room.type;
                if (room.type == "Phòng VIP")
                {
                    btn_title.BackColor = Color.Yellow;
                }
                else if (room.type == "Phòng đơn")
                {
                    btn_title.BackColor = Color.FromArgb(253, 138, 114);
                }
                else
                {
                    btn_title.BackColor = Color.FromArgb(24, 161, 251);
                }
                btn_title.Dock = DockStyle.Top;
                btn_title.ForeColor = Color.FromArgb(26, 25, 60);
                btn_title.FlatStyle = FlatStyle.Flat;
                btn_title.FlatAppearance.BorderSize = 0;
                btn_title.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btn_title.Height = 36;
                //btn content
                btn_content.Text = room.name;
                btn_content.Height = 130;
                btn_content.Dock = DockStyle.Fill;
                btn_content.FlatStyle = FlatStyle.Flat;
                btn_content.Font = new Font("Century Gothic", 20);
                btn_content.ForeColor = Color.FromArgb(249, 118, 176);
                btn_content.BackColor = Color.FromArgb(26, 25, 60);
                //btn status
                btn_status.Text = "";
                btn_status.Text = room.status;
                btn_status.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                btn_status.Dock = DockStyle.Bottom;
                btn_status.Height = 36;
                btn_status.ForeColor = Color.FromArgb(249, 118, 176);
                btn_status.BackColor = Color.FromArgb(26, 25, 60);
                btn_status.FlatStyle = FlatStyle.Flat;
                btn_status.Cursor = Cursors.Hand;
                btn_title.Tag = room.room_id;
                btn_title.Click += detailRoom;
                btn_content.Tag = room.room_id;
                btn_content.Click += detailRoom;
                btn_status.Tag = room.room_id;
                btn_status.Click += detailRoom;
                panel_container.Controls.Add(panel_item);
            }
        }

    }
}
