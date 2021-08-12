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
    public partial class frAddItem : Form
    {
        private ItemBusiness itemBusiness;
        private ServiceBusiness serviceBusiness;
        private int billID;
        public frAddItem()
        {
            InitializeComponent();
            itemBusiness = new ItemBusiness();
            serviceBusiness = new ServiceBusiness();
            this.billID = -1;
        }
        public frAddItem(int billId)
        {
            InitializeComponent();
            serviceBusiness = new ServiceBusiness();
            itemBusiness = new ItemBusiness();
            this.billID = billId;
        }
        private void frAddItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            data_item.Rows.Clear();
            try
            {
                List<Item> listItem = itemBusiness.getAllItems();
                foreach (Item i in listItem)
                {
                    data_item.Rows.Add(i.name, (double)i.price);
                }
            }
            catch
            {
                MessageBox.Show("Loi co so du lieu!");
            }
            
        }


        private void close(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void showDetailItem(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_item.Rows[index];
                string name = selectedRows.Cells[0].Value.ToString();
                lb_name.Text = name;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            if (this.billID == -1)
            {
                MessageBox.Show("Chọn dịch vụ cần thêm!");
                return;
            }
            try
            {
                int result = serviceBusiness.addService(this.billID, lb_name.Text, Int32.Parse(txt_quantity.Text));
                if (result == 1)
                {
                    MessageBox.Show("Thêm thành công!");

                }
                else
                {
                    MessageBox.Show("Số lượng trong kho không đủ!");
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
