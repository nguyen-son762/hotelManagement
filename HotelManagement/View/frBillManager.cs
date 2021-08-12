using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frBillManager : Form
    {
        private BillBusiness billBusiness;
        private RoomBusiness roomBusiness;
        private CustomerBusiness customerBusiness;
        private List<Bill> list;
        private int id;
        public frBillManager()
        {
            InitializeComponent();
            billBusiness = new BillBusiness();
            roomBusiness = new RoomBusiness();
            customerBusiness = new CustomerBusiness();
            list = new List<Bill>();
            list = billBusiness.getAllBills();
        }
        private void LoadData()
        {
            data_bill.Rows.Clear();
            try
            {
                foreach(Bill b in list)
                {
                    Room r = roomBusiness.getRoomByID((int)b.room_id);
                    Customer c = customerBusiness.getCustomer((int)b.customer_id);
                    DateTime x = b.begin_date.Value;
                    CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                    decimal cc = (decimal)b.total;
                    string t= cc.ToString("C0", culture);
                    data_bill.Rows.Add(b.bill_id,r.name, c.first_name + c.last_name, b.begin_date.Value.ToString("dd/MM/yyyy"), b.end_date.Value.ToString("dd/MM/yyyy"), b.status, b.created_at.Value.ToString("dd/MM/yyyy HH:mm:ss"), t);
                }
            }
            catch
            {

            }

        }

        private void show(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_bill.Rows[index];
                this.id= Int32.Parse(selectedRows.Cells[0].Value.ToString());
                txt_id.Text = selectedRows.Cells[0].Value.ToString();
            }
        }

        private void data_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }


        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void frBillManager_Load_1(object sender, EventArgs e)
        {
            LoadData();
            begin_date.CustomFormat = "dd/MM/yyyy";
            end_date.CustomFormat = "dd/MM/yyyy";
            begin_date.Value = DateTime.Now;
            end_date.Value = DateTime.Now;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneGradientButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa không?", "Xóa hóa đơn", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    billBusiness.deleteBill(this.id);
                    LoadData();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy hóa đơn");
                }
            }
        }

        private void data_bill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            this.list = billBusiness.searchByDate(begin_date.Value, end_date.Value);
            LoadData();
        }
        // eport excel
        public void exportExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook=new XLWorkbook())
                        {
                            DataTable dt = new DataTable();
                            foreach (DataGridViewColumn col in data_bill.Columns)
                            {
                                dt.Columns.Add(col.Name);
                            }

                            foreach (DataGridViewRow row in data_bill.Rows)
                            {
                                DataRow dRow = dt.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dRow[cell.ColumnIndex] = cell.Value;
                                }
                                dt.Rows.Add(dRow);
                            }
                            workbook.Worksheets.Add(dt, "Bills");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất file thành công!");
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Export file excel
        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            exportExcel();
        }
    }
}
