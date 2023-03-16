using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Double.Parse(txtKo.Text) + Double.Parse(txtMath.Text) + Double.Parse(txtEn.Text);

            double avg = sum / 3;

            txtSum.Text = sum.ToString();
            txtEverage.Text = avg.ToString("#.#");
        }
    }
}
