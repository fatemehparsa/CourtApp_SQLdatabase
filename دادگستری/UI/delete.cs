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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
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

                c.court_number = Convert.ToInt32(textBox1.Text);
                c.delete();
            }
            else if (csi == 1)
            {
                j.personnely_code = Convert.ToInt32(textBox1.Text);
                j.delete();
            }
            else if (csi == 2)
            {
                l.personnely_code = Convert.ToInt32(textBox1.Text);
                l.delete();
            }
            else if (csi == 3)
            {
                cor.complainer_number = Convert.ToInt32(textBox1.Text);
                cor.delete();
            }
            else if (csi == 4)
            {
                cot.complaint_n = Convert.ToInt32(textBox1.Text);
                cot.delete();

            }
            else if (csi == 5)
            {
                w.w_n= Convert.ToInt32(textBox1.Text);
                w.delete();
            }
            else if (csi == 6)
            {
                cr.criminate_number = Convert.ToInt32(textBox1.Text);
                cr.delete();
            }
            MessageBox.Show(" sucssesful");
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
