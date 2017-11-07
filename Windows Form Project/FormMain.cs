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
            FormTaoTaiLieu formTaoTaiLieu = new FormTaoTaiLieu();
            this.Enabled = false;
            formTaoTaiLieu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
