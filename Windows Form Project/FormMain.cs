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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
     
        }
       
        private void thêmTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormTaoTaiLieu formTaoTaiLieu = new FormTaoTaiLieu();
            this.Enabled = false;
            formTaoTaiLieu.Show();*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //TODO..............

            DialogResult dig = MessageBox.Show("Đăng xuất thành công ! Bạn có muốn đăng nhập với tài khoản khác không ? ",
           "Thông báo !", MessageBoxButtons.YesNo);
            if (dig == DialogResult.No)
            {
               this.Close();
            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
