using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frStaffManager : Form
    {
        private StaffBusiness staffBusiness;
        List<Staff> list;
        private int id;
        public frStaffManager()
        {
            InitializeComponent();
            staffBusiness = new StaffBusiness();
            list = new List<Staff>();
        }

        private void frStaffManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            data_staff.Rows.Clear();
            list = staffBusiness.getAllStaff();
            foreach (Staff s in list)
            {
                data_staff.Rows.Add(s.staff_id, s.name, s.address, s.position);
            }
        }

        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_staff.Rows[index];
                this.id = Int32.Parse(selectedRows.Cells[0].Value.ToString());
                txt_name.Text = selectedRows.Cells[1].Value.ToString();
                txt_address.Text = selectedRows.Cells[2].Value.ToString();
                txt_position.Text= selectedRows.Cells[3].Value.ToString();
            }
        }

        // Thêm thông tin
        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_address.Text == "" || txt_position.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống");
                return;
            }
            try
            {
                Staff staff = new Staff();
                staff.name = txt_name.Text;
                staff.address = txt_address.Text;
                staff.position = txt_position.Text;
                staffBusiness.addStaff(staff);
                MessageBox.Show("Thêm thành công");
                txt_name.Text = "";
                txt_position.Text = "";
                txt_address.Text = "";
                LoadData();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        // Sửa thông tin
        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_address.Text == "" || txt_position.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Sửa thông tin", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = this.id;
                try
                {
                    Staff staff = new Staff();
                    staff.name = txt_name.Text;
                    staff.address = txt_address.Text;
                    staff.position = txt_position.Text;
                    staffBusiness.updateStaff(this.id, staff);
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần sửa!");
                }
            }
        }
        // Xóa thông tin
        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_address.Text == "" || txt_position.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = this.id;
                try
                {
                    staffBusiness.deleteStaff(id);
                    LoadData();
                    MessageBox.Show("Xóa phòng thành công!");

                }
                catch
                {
                    MessageBox.Show("Không có đối tượng cần xóa!");
                }
            }
        }
    }
}
