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
    public partial class search1 : Form
    {
        public search1()
        {
            InitializeComponent();
        }

        private void search1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            court c = new court();
            judge j = new judge();
            lawyer l = new lawyer();
            complainer cor = new complainer();
            complaint cot = new complaint();
            warrant w = new warrant();
            criminate cr = new criminate();

            int csi = comboBox1.SelectedIndex;

            if (csi == 0)
            {
                dataGridView1.DataSource = c.select();
                
            }
            else if (csi == 1)
            {
                dataGridView1.DataSource = j.select();
            }
            else if (csi == 2)
            {
                dataGridView1.DataSource = l.select();

            }
            else if (csi == 3)
            {
                dataGridView1.DataSource = cor.select();

            }
            else if (csi == 4)
            {
                dataGridView1.DataSource = cot.select();

            }
            else if (csi == 5)
            {
                dataGridView1.DataSource = w.select();
            }
            else if (csi == 6)
            {
                dataGridView1.DataSource = cr.select();
            }

            
        }
    }
}
