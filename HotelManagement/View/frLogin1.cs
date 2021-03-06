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
    public partial class frLogin1 : Form
    {
        private readonly AdminManager hotelManager;
        public frLogin1()
        {
            InitializeComponent();
            this.hotelManager = new AdminManager();
        }

        private void frLogin1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click_1(sender, e);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "")
            {
                MessageBox.Show("Username không được để trống!");
                return;
            }
            if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }
            Admin admin = hotelManager.signin(txt_username.Text, txt_password.Text);
            if (admin != null)
            {
                frHome home = new frHome();
                home.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}
