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
    public partial class frAddBill : Form
    {
        private int idCustomer;
        private int roomID;
        private string statusBill;
        private CustomerBusiness customerBusiness;
        private BillBusiness billBusiness;
        private RoomBusiness roomBusiness;
        public frAddBill()
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
            billBusiness = new BillBusiness();
        }
        public frAddBill(int roomId,string status)
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
            billBusiness = new BillBusiness();
            this.roomID = roomId;
            this.statusBill = status;
            roomBusiness = new RoomBusiness();
        }

        private void showDetailCustomer(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_customer.Rows[index];
                this.idCustomer = Int32.Parse(selectedRows.Cells[6].Value.ToString());
                txt_search.Text = selectedRows.Cells[0].Value.ToString()+" "+ selectedRows.Cells[1].Value.ToString();
            }
        }

        private void frAddBill_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            data_customer.Rows.Clear();
            data_customer.Columns["id"].Visible = false;
            try
            {
                List<Customer> list = customerBusiness.getAllCustomer();
                foreach (Customer c in list)
                {
                    data_customer.Rows.Add(c.first_name, c.last_name, c.address, c.sex, c.phone_number, c.identity_card_number, c.customer_id);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }


        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            if (this.statusBill == "Đặt phòng")
            {
                try
                {
                    Bill bill = new Bill();
                    bill.customer_id = this.idCustomer;
                    bill.room_id = this.roomID;
                    bill.status = "Chưa thanh toán";
                    bill.begin_date = DateTime.Now;
                    bill.created_at = DateTime.Now;
                    roomBusiness.updateRoomStatus(this.roomID, "Có người");
                    billBusiness.addBill(bill);
                    MessageBox.Show("Tạo hóa đơn thành công!");
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Tạo hóa đơn thất bại!");
                }
            }
            else
            {

                try
                {
                    Bill bill = new Bill();
                    bill.customer_id = this.idCustomer;
                    bill.room_id = this.roomID;
                    bill.status = "Đặt trước";
                    bill.begin_date = DateTime.Now;
                    bill.created_at = DateTime.Now;
                    roomBusiness.updateRoomStatus(this.roomID, "Đã đặt");
                    billBusiness.addBill(bill);
                    MessageBox.Show("Đặt phòng thành công!");
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu!");
                }
            }
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            data_customer.Rows.Clear();
            data_customer.Columns["id"].Visible = false;
            try
            {
                List<Customer> list = customerBusiness.searchCustomer(txt_search.Text);
                foreach (Customer c in list)
                {
                    data_customer.Rows.Add(c.first_name, c.last_name, c.address, c.sex, c.phone_number, c.identity_card_number, c.customer_id);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu!");
            }
        }
    }
}
