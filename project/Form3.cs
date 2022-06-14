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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            if((radioButtonseconddislike.Checked == false) && (radioButtonSecondlike.Checked == false) && (radioButtonThird1.Checked == false) && (radioButtonThird2.Checked == false) && (radioButtonThird3.Checked == false))
            {
                warningForm w = new warningForm();
                w.ShowDialog();
            }
            else
            {
                this.Visible = false;
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
        }
    }
}
