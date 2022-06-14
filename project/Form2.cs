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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            if ((radioButtonFirst1.Checked == false) && (radioButtonFirst2.Checked == false) && (radioButtonFirst3.Checked == false) && (radioButtonFirst4.Checked == false))
            {
                warningForm w = new warningForm();
                w.ShowDialog();
            }
            else if((radioButtonFirst4.Checked == true))
            {
                if((radioButtonFirstChecked1.Checked == false)&& radioButtonFirstChecked2.Checked == false)
                {
                    warningForm w = new warningForm();
                    w.ShowDialog();
                }
                else
                {
                    this.Visible = false;
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
            else
            {
                this.Visible = false;
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void radioButtonFirstChecked1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFirst4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFirst4.Checked == true)
            {
                radioButtonFirstChecked1.Enabled = true;
                radioButtonFirstChecked2.Enabled = true;
            }
            else
            {
                radioButtonFirstChecked2.Enabled = false;
                radioButtonFirstChecked1.Enabled = false;
            }

           
        }

        private void radioButtonFirst4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
