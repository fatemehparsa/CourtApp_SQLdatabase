using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using دادگستری.BL;
using دادگستری.DA;

namespace دادگستری.UI
{
    public partial class function : Form
    {
        public function()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            function12 f = new function12() ;
            f.f1data =Convert.ToInt32( textBox1.Text);
            dataGridView1.DataSource = f.f1();
        }

        private void function_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            function12 f = new function12();
            f.f2data = Convert.ToInt32(textBox2.Text);
            dataGridView1.DataSource = f.f2();
        }
    }
}
