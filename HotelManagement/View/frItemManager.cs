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
    public partial class frItemManager : Form
    {
        private ItemBusiness itemBusiness;
        private List<Item> list;
        private int id;
        public frItemManager()
        {
            InitializeComponent();
            itemBusiness = new ItemBusiness();
            list = new List<Item>();
        }

        private void frItemManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            data_item.Rows.Clear();
            try
            {
                list = itemBusiness.getAllItems();
                foreach (Item i in list)
                {
                    data_item.Rows.Add(i.item_id, i.name, (int)i.price, i.amount);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu");
            }
        }

        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_item.Rows[index];
                this.id = Int32.Parse(selectedRows.Cells[0].Value.ToString());
                txt_name.Text = selectedRows.Cells[1].Value.ToString();
                txt_price.Text = selectedRows.Cells[2].Value.ToString();
                txt_amount.Text = selectedRows.Cells[3].Value.ToString();
            }
        }


        private void siticoneGradientButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa không?", "Xóa vật tư", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    itemBusiness.deleteItem(this.id);
                    LoadData();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy vật tư cần xóa");
                }
            }
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_price.Text == "" || txt_amount.Text == "")
            {
                MessageBox.Show("Dữ liệu không được để trống");
                return;
            }
            try
            {
                Item item = new Item();
                item.name = txt_name.Text;
                item.price = Decimal.Parse(txt_price.Text);
                item.amount = Int32.Parse(txt_amount.Text);
                itemBusiness.addItem(item);
                LoadData();
                MessageBox.Show("Thêm thành công");
                txt_name.Text = "";
                txt_price.Text = "";
                txt_amount.Text = "";
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính xác");
            }
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý sửa không?", "Sửa vật tư", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Item item = new Item();
                    item.name = txt_name.Text;
                    item.price = Decimal.Parse(txt_price.Text);
                    item.amount = Int32.Parse(txt_amount.Text);
                    itemBusiness.updateItem(this.id, item);
                    LoadData();
                    MessageBox.Show("Sửa thành công");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không chính xác");
                }
            }
        }
    }
}
