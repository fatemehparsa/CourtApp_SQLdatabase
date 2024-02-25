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
using دادگستری .DA;


namespace دادگستری.UI
{
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                search1 s = new search1();
                s.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            update edit1 = new update();
            edit1.Show();

        }

        private void selection_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            insert i = new insert();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            delete d = new delete();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           function f = new function();
            f.Show();
        }
    }
}
