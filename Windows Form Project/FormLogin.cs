using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Project
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sự kiện 1 : Kiếm tra tính hợp lệ
            if(txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống. Vui lòng nhập lại.","Thông báo !");
            }
            else
            {
                if(txtTaiKhoan.Text != "Nội dung trong DataBase" || txtMatKhau.Text != "Nội dung trong DataBase")
                {
                    DialogResult dig = MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác ! Bạn có muốn nhập lại",
                        "Thông báo !",MessageBoxButtons.YesNo);
                    if(dig == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Bạn có thực sự muốn thoát ?",
            "Thông báo !", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
