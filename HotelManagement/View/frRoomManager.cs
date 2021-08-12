using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frRoomManager : Form
    {
        private RoomBusiness roomBusiness;
        public frRoomManager()
        {
            InitializeComponent();
            roomBusiness = new RoomBusiness();
        }

        private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void frRoomManager_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            data_service.Rows.Clear();
            try
            {
                List<Room> rooms = roomBusiness.getAllRooms();
                foreach (Room r in rooms)
                {
                    int number = (int)r.price;
                    data_service.Rows.Add(r.room_id, r.name, number, r.type, r.status);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu!");
            }
        }
        private void getDetailRoom(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_service.Rows[index];
                string id = selectedRows.Cells[0].Value.ToString();
                string name = selectedRows.Cells[1].Value.ToString();
                string price = selectedRows.Cells[2].Value.ToString();
                string type = selectedRows.Cells[3].Value.ToString();
                string status = selectedRows.Cells[4].Value.ToString();
                txt_name.Text = name;
                //double p = Convert.ToDouble(price);
                //CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                //txt_price.Text = p.ToString("C0", culture);
                txt_price.Text = price;
                cb_type.Text = type;
                txt_id.Text = id;
                cb_status.Text = status;
            }

        }

        private void txt_name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            

        }

        private void data_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            List<Room> rooms = roomBusiness.getAllRooms();
            foreach (Room r in rooms)
            {
                if (r.name == txt_name.Text)
                {
                    MessageBox.Show("Tên phòng đã tồn tại!");
                    return;
                }
            }
            int n = 0;
            if (!int.TryParse(txt_price.Text, out n) || Int32.Parse(txt_price.Text) < 0)
            {
                MessageBox.Show("Định dạng không đúng! Nhập lại.");
                return;
            }
            else
            {

                Room room = new Room();
                room.name = txt_name.Text;
                room.price = Int32.Parse(txt_price.Text);
                room.type = cb_type.Text;
                room.status = "Còn trống";
                try
                {
                    roomBusiness.addRoom(room);
                    LoadDataGrid();
                    MessageBox.Show("Thêm phòng thành công!");
                    txt_name.Text = "";
                    txt_price.Text = "";
                }
                catch
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu!");
                }
            }
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa không?", "Xóa phòng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Int32.Parse(txt_id.Text);
                try
                {
                    roomBusiness.deleteRoom(id);
                    LoadDataGrid();
                    MessageBox.Show("Xóa phòng thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu!");
                }
            }
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            List<Room> rooms = roomBusiness.getAllRooms();
            foreach (Room r in rooms)
            {
                if (r.name == txt_name.Text && Int32.Parse(txt_id.Text) != r.room_id)
                {
                    MessageBox.Show("Tên phòng đã tồn tại!");
                    return;
                }
            }
            int n = 0;
            if (!int.TryParse(txt_price.Text, out n) || Int32.Parse(txt_price.Text) < 0)
            {
                MessageBox.Show("Định dạng không đúng! Nhập lại.");
                return;
            }
            else
            {
                Room room = new Room();
                room.room_id = Int32.Parse(txt_id.Text);
                room.name = txt_name.Text;
                room.price = Int32.Parse(txt_price.Text);
                room.type = cb_type.Text;
                room.status = cb_status.Text;
                try
                {
                    roomBusiness.fixRoom(room);
                    LoadDataGrid();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu!");
                }
            }
        }
    }
}
