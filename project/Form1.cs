using System;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text == "") || ((radioButtonSex1.Checked == false) && (radioButtonSex2.Checked == false)))
            {
                warningForm w = new warningForm();
                w.ShowDialog();
            }
            else
            {
                this.Visible = false;
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
