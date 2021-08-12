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
    public partial class frStatisticalManager : Form
    {
        private BillBusiness billBusiness;
        public frStatisticalManager()
        {
            InitializeComponent();
            billBusiness = new BillBusiness();
        }

        private void frStatisticalManager_Load(object sender, EventArgs e)
        {
            lb_total.Anchor = AnchorStyles.Top;
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {

            decimal total = billBusiness.getStatistical(Int32.Parse(cb_begin.Text), Int32.Parse(cb_end.Text), Int32.Parse(year.Text));

            if(Int32.Parse(cb_begin.Text)> Int32.Parse(cb_end.Text))
            {
                MessageBox.Show("Tháng kết thúc phải lớn hơn tháng bắt đầu!");
                return;
            }
            if (total > 0)
            {
                CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
                lb_total.Text = total.ToString("C0", culture);
            }
            else
            {
                lb_total.Text = "0đ";
            }
        }
    }
}
