using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtTaikhoan.Text == "") || (txtMatkhau.Text == ""))
            {
                MessageBox.Show("Nhập thông tin", "Thông báo");
            }
            else
            {
                if ((txtTaikhoan.Text == "khang") && (txtMatkhau.Text == "123"))
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Form2 f = new Form2();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
                }
            } 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
