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
    public partial class insert : Form
    {
        public insert()
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
                c.court_addr = Convert.ToString(textBox7.Text);
                c.court_name = Convert.ToString(textBox8.Text);
                c.add();
            }
            else if (csi == 1)
            {
                j.personnely_code= Convert.ToInt32(textBox1.Text); ;
                j.judge_name=Convert.ToString(textBox2.Text); 
                j.judge_id_code = Convert.ToInt32(textBox3.Text);
                j. judge_gender = Convert.ToString(textBox4.Text);
                j.judge_addr = Convert.ToString(textBox5.Text);
                j.judge_license_code = Convert.ToInt32(textBox6.Text);
                j.court_n = Convert.ToInt32(textBox7.Text);
                j.add();
            }
            else if (csi == 2)
            {
                l.personnely_code = Convert.ToInt32(textBox1.Text); ;
                l.lawyer_name = Convert.ToString(textBox2.Text);
                l.lawyer_id_code = Convert.ToInt32(textBox3.Text);
                l.lawyer_gender = Convert.ToString(textBox4.Text);
                l.lawyer_addr = Convert.ToString(textBox5.Text);
                l.agancy_license_code = Convert.ToInt32(textBox6.Text);
                l.court_n = Convert.ToInt32(textBox7.Text);
                l.add();
            }
            else if (csi == 3)
            {
                cor.complainer_number = Convert.ToInt32(textBox1.Text);
                cor.complainer_name = Convert.ToString(textBox2.Text);
                cor.complainer_addr = Convert.ToString(textBox3.Text);
                cor.complainer_id_code = Convert.ToString(textBox4.Text);
                cor.complainer_phone_n = Convert.ToInt32(textBox5.Text);
                cor.complainer_gender = Convert.ToString(textBox6.Text);
                cor.add();
            }
            else if (csi == 4)
            {
                cot.complaint_n = Convert.ToInt32(textBox1.Text);
                cot.c_date = Convert.ToInt32(textBox15.Text);
                cot.c_text = Convert.ToString(textBox18.Text);
                cot.result_W_n = Convert.ToInt32(textBox19.Text);
                cot.complainer_n = Convert.ToInt32(textBox9.Text);
                cot.criminate_n = Convert.ToInt32(textBox21.Text);
                cot.j_personnely_code = Convert.ToInt32(textBox20.Text);
                cot.l_personnely_code = Convert.ToInt32(textBox22.Text);
                cot.court_n = Convert.ToInt32(textBox16.Text);
                cot.add();

            }
            else if (csi == 5)
            {

                w.w_n= Convert.ToInt32(textBox1.Text);
                w.pronouncement_date = Convert.ToInt32(textBox17.Text); ;
                w.fulfil_date = Convert.ToInt32(textBox23.Text); ;
                w.warrant_text= Convert.ToInt32(textBox24.Text);
                w.add();
            }
            else if (csi == 6)
            {
                cr.criminate_number = Convert.ToInt32(textBox1.Text);
                cr.criminate_name = Convert.ToString(textBox11.Text);
                cr.criminate_addr = Convert.ToString(textBox10.Text);
                cr.criminate_id_code = Convert.ToString(textBox12.Text);
                cr.criminate_phone_n = Convert.ToInt32(textBox13.Text);
                cr.criminate_gender = Convert.ToString(textBox14.Text);
                cr.add();
            }
            MessageBox.Show(" sucssesful");
        }

        private void insert_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            int csi = comboBox1.SelectedIndex;

            if (csi == 0)
            {
                
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Show();
                groupBox4.Hide();
                groupBox5.Hide();

            }
            else if (csi == 1)
            {
               
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
            }
            else if (csi == 2)
            {
    
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();

            }
            else if (csi == 3)
            {

                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
            }
            else if (csi == 4)
            {
 
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Show();
                groupBox5.Hide();
            }
            else if (csi == 5)
            {

                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Show();

            }
            else if (csi == 6)
            {
    
                groupBox1.Hide();
                groupBox2.Show();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();
            }

        }
    }
}
