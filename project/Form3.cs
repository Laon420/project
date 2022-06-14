using System;
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
            if (radioButtonSecondlike.Checked == false && radioButtonseconddislike.Checked == false)
            {
                warningForm w = new warningForm();
                w.ShowDialog();
            }
            else if (radioButtonThird1.Checked == false && radioButtonThird2.Checked == false && radioButtonThird3.Checked == false)
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
