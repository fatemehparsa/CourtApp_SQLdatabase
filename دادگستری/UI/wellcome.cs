using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using دادگستری.DA;

namespace دادگستری.UI
{
    public partial class wellcome : Form
    {
        public wellcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginDA L = new loginDA();
            L.user = textBox1.Text;
            L.pass = textBox2.Text;

            bool res = loginDA.Realize(L);
            if (res)
            {
                MessageBox.Show(" You are login");
                selection s = new selection();
                s.Show();

            }
            else
            {
                MessageBox.Show(" wrong user or pass");
                textBox1.Clear();
                textBox2.Clear();

            }
        }
            private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void wellcome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
