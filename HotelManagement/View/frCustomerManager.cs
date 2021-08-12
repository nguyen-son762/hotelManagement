using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frCustomerManager : Form
    {
        private int roomID;
        private BillBusiness billBusiness;
        private CustomerBusiness customerBusiness;
        private int idCustomer;
        public frCustomerManager()
        {
            InitializeComponent();
            billBusiness = new BillBusiness();
            customerBusiness = new CustomerBusiness();
        }
        public frCustomerManager(int roomId)
        {
            InitializeComponent();
            this.roomID = roomId;
            billBusiness = new BillBusiness();
            customerBusiness = new CustomerBusiness();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void frAddBill_Load(object sender, EventArgs e)
        {
            rd_female.Checked = true;
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            

        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void LoadData()
        {
            data_customer.Rows.Clear();
            data_customer.Columns["id"].Visible = false;
            try
            {
                List<Customer> list= customerBusiness.getAllCustomer();
                foreach(Customer c in list)
                {
                    data_customer.Rows.Add(c.first_name,c.last_name, c.address, c.sex, c.phone_number, c.identity_card_number,c.customer_id);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu!");
            }
        }

        private void showDetailCustomer(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_customer.Rows[index];
                firstName.Text=selectedRows.Cells[0].Value.ToString();
                lastName.Text= selectedRows.Cells[1].Value.ToString();
                address.Text= selectedRows.Cells[2].Value.ToString();
                string gender= selectedRows.Cells[3].Value.ToString();
                if (gender == "Nam")
                {
                    rd_female.Checked = true;
                }
                else
                {
                    rd_male.Checked = true;
                }
                phoneNumber.Text= selectedRows.Cells[4].Value.ToString();
                identityCard.Text= selectedRows.Cells[5].Value.ToString();
                this.idCustomer = Int32.Parse(selectedRows.Cells[6].Value.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa không?", "Xóa khách hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    customerBusiness.deleteCustomer(this.idCustomer);
                    MessageBox.Show("Xóa khách hàng thành công !");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Chưa có đối tượng cần xóa!");
                }
            }
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || address.Text == "" || phoneNumber.Text == "" || identityCard.Text == "")
            {
                MessageBox.Show("Dữ liệu đầu vào không được để trống!");
                return;
            }
            try
            {
                Customer customer = new Customer();
                customer.first_name = firstName.Text;
                customer.last_name = lastName.Text;
                customer.address = address.Text;
                if (rd_female.Checked == true)
                {
                    customer.sex = "Nam";
                }
                else
                {
                    customer.sex = "Nữ";
                }
                bool number = Regex.IsMatch(phoneNumber.Text, @"^\d+$");
                if (number)
                {
                    customer.phone_number =phoneNumber.Text;
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }
                bool iden_number = Regex.IsMatch(identityCard.Text, @"^\d+$");
                if (iden_number)
                {
                    customer.identity_card_number = identityCard.Text;
                }
                else
                {
                    MessageBox.Show("Số chứng minh nhân dân không hợp lệ");
                    return;
                }
                customerBusiness.addCustomer(customer);
                LoadData();
                MessageBox.Show("Thêm thành công");
                firstName.Text = "";
                lastName.Text = "";
                address.Text = "";
                phoneNumber.Text = "";
                identityCard.Text = "";
                rd_female.Checked = true;
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Định dạng đầu vào không hợp lệ!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton4_Click(object sender, EventArgs e)
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
                MessageBox.Show("Tìm kiếm thất bại!");
            }
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || address.Text == "" || phoneNumber.Text == "" || identityCard.Text == "")
            {
                MessageBox.Show("Dữ liệu đầu vào không được để trống!");
                return;
            }
            try
            {
                Customer cus = new Customer();
                cus.first_name = firstName.Text;
                cus.last_name = lastName.Text;
                cus.address = address.Text;
                if (rd_female.Checked == true)
                {
                    cus.sex = "Nam";
                }
                else
                {

                    cus.sex = "Nữ";
                }
                cus.phone_number = phoneNumber.Text;
                cus.identity_card_number = identityCard.Text;
                customerBusiness.updateCustomer(this.idCustomer, cus);
                LoadData();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
