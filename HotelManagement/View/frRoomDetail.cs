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
using HotelManagement.Business;
namespace HotelManagement.View
{
    public partial class frRoomDetail : Form
    {
        private BillBusiness billBusiness;
        private RoomBusiness roomBusiness;
        private ServiceBusiness serviceBusiness;
        private ItemBusiness itemBusiness;
        private CustomerBusiness customerBusiness;
        public int Id;
        private int serviceId;
        private int billId;
        private decimal total;
        public frRoomDetail(int id)
        {
            InitializeComponent();
            billBusiness = new BillBusiness();
            roomBusiness = new RoomBusiness();
            serviceBusiness = new ServiceBusiness();
            itemBusiness = new ItemBusiness();
            customerBusiness = new CustomerBusiness();
            this.Id = id;
            data_service.Columns["id"].Visible = false;
            this.billId = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            checkin.FormatCustom = "dd/MM/yyyy";
            checkout.FormatCustom = "dd/MM/yyyy";
        }
        //Hiển thị lên datagridview
        private void LoadData()
        {
            data_service.Rows.Clear();
            // get room detail and bill
            Room room = roomBusiness.getRoomByID(this.Id);
            string Id = room.room_id + "";
            roomName.Text = room.name;
            roomPrice.Text = (double)room.price + "";
            roomStatus.Text = room.status;
            if (room.status != "Còn trống")
            {
                btn_booking.Visible = false;
            }
            roomType.Text = room.type;
            Bill bill = billBusiness.getBillByRoomId(Int32.Parse(Id));
            if (bill == null)
            {
                checkin.Value = DateTime.Now;
                checkout.Value = DateTime.Now;
                btn_pay.Visible = false;
                btn_add.Visible = false;
                btn_fix.Visible = false;
                btn_delete.Visible = false;
                if (room.status == "Đang bảo trì")
                {
                    btn_pay.Visible = false;
                    btn_createBill.Visible = false;
                }
                return;
            }
            btn_createBill.Visible = false;
            if (bill.status == "Đặt trước")
            {
                btn_createBill.Visible = true;
                btn_pay.Visible = false;
            }
            if (bill.status == "Chưa thanh toán")
            {
                btn_pay.Visible = true;
                btn_add.Visible = true;
                btn_fix.Visible = true;
                btn_delete.Visible = true;
            }
            if (room.status == "Đang bảo trì")
            {
                btn_pay.Visible = false;
                btn_createBill.Visible = false;
            }
            this.billId = bill.bill_id;
            //get all services
            List<Service> listService = serviceBusiness.getServicesByBillId(this.billId);
            string d = bill.begin_date + "";
            checkin.Value = DateTime.Parse(d);
            checkout.Value = DateTime.Now;
            //Tổng tiền sử dụng dịch vụ
            double total = 0;
            foreach (Service service in listService)
            {
                string IdItem = service.item_id + "";
                Item item = itemBusiness.getItemById(Int32.Parse(IdItem));
                data_service.Rows.Add(item.name, (int)item.price, service.quantity, (double)item.price * service.quantity, service.service_id);
                total += (double)((int)item.price * service.quantity);
            }
            // total
            TimeSpan difference = checkout.Value - checkin.Value;
            double days = difference.TotalDays;
            double day = Math.Round(days);
            if (day == 0)
            {
                day = 1;
            }

            double prr = Double.Parse(roomPrice.Text);
            double p = Convert.ToDouble(total + day * prr);
            this.total = (decimal)p;
            billBusiness.updateTotal(billId, (decimal)p);
            CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
            lb_total.Text = p.ToString("C0", culture);
            //get Customer
            Customer customer = customerBusiness.getCustomer((int)bill.customer_id);
            if (customer != null)
            {
                customerName.Text = customer.first_name + " " + customer.last_name;
            }
        }
        // hàm xử lý khi click vào datagridview
        private void showDetailService(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRows = data_service.Rows[index];
                string name = selectedRows.Cells[0].Value.ToString();
                string count = selectedRows.Cells[2].Value.ToString();
                this.serviceId = Int32.Parse(selectedRows.Cells[4].Value.ToString());
                txt_nameService.Text = name;
                txt_quantity.Text = count;
            }
        }

        private void btn_createBill_Click(object sender, EventArgs e)
        {
            if (this.billId == -1)
            {
                frAddBill fr = new frAddBill(this.Id, "Đặt phòng");
                fr.ShowDialog();
                if (fr.DialogResult == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                try
                {
                    billBusiness.updateBillStatus(this.billId, "Chưa thanh toán");
                    this.Refresh();
                    LoadData();
                    MessageBox.Show("Đặt phòng thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu!");

                }
            }
        }

        private void exitForm(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            frAddBill fr = new frAddBill(this.Id, "Đặt trước");

            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                this.Refresh();
                LoadData();
            }
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        // Nút thanh toán
        private void btn_pay_Click(object sender, EventArgs e)
        {
        }

        private void change_end(object sender, EventArgs e)
        {
            if (billId != -1 && this.Id > 0)
            {
                double totalPay = 0;
                List<Service> listService = serviceBusiness.getServicesByBillId(this.billId);
                foreach (Service service in listService)
                {
                    string IdItem = service.item_id + "";
                    Item item = itemBusiness.getItemById(Int32.Parse(IdItem));
                    totalPay += (double)((int)item.price * service.quantity);
                }
                TimeSpan difference = checkout.Value - checkin.Value;
                double days = difference.TotalDays;
                double day = Math.Round(days);
                if (day == 0)
                {
                    day = 1;
                }
                double prr = Double.Parse(roomPrice.Text);
                double p = Convert.ToDouble(totalPay + day * prr);
                this.total = (decimal)p;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                lb_total.Text = total.ToString("C0", culture);
            }
        }

        private void data_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa không?", "Xóa dịch vụ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    serviceBusiness.deleteService(this.serviceId);
                    LoadData();
                    MessageBox.Show("Xóa thành công!");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int result = serviceBusiness.updateService(this.serviceId, Int32.Parse(txt_quantity.Text));
                if (result == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Kho hàng không đủ số lượng!");
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Định dạng không đúng!" + x.Message);
            }
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            frAddItem fr = new frAddItem(this.billId);
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void siticoneGradientButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thanh toán không?", "Thanh toán phòng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    double totalPay = 0;
                    List<Service> listService = serviceBusiness.getServicesByBillId(this.billId);
                    foreach (Service service in listService)
                    {
                        string IdItem = service.item_id + "";
                        Item item = itemBusiness.getItemById(Int32.Parse(IdItem));
                        totalPay += (double)((int)item.price * service.quantity);
                    }
                    TimeSpan difference = checkout.Value - checkin.Value;
                    double days = difference.TotalDays;
                    double day = Math.Round(days);
                    if (day == 0)
                    {
                        day = 1;
                    }
                    double prr = Double.Parse(roomPrice.Text);
                    double p = Convert.ToDouble(totalPay + day * prr);
                    this.total = (decimal)p;
                    CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                    billBusiness.payBill(billId, checkout.Value, this.total);
                    MessageBox.Show("Số tiền bạn cần thanh toán là : " + total.ToString("C0", culture));
                    LoadData();
                    btn_booking.Visible = true;
                    btn_createBill.Visible = true;
                    lb_total.Text = "0";
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Thanh toán thất bại!");
                }
            }
        }
    }
}
