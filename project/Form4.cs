using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label1.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            warningForm w= new warningForm();
            if(radioButtonYes.Checked==false && radioButtonNo.Checked == false)
            {
                w.ShowDialog();
            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                w.ShowDialog();
            }
            else if(checkBox4.Checked == true && textBox1.Text == "")
            {
                    w.ShowDialog();
            }
            else
            {
                this.Visible = false;
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
        }
    }
}
