﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string states = "";

            CheckBox[] cBox = {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5};

            foreach(var c in cBox)
            {
                states += string.Format("{0} : {1}\n", c.Text, c.Checked);
            }
            MessageBox.Show(states, "check States");

            string summary = "좋아하는 과일은 ";

            foreach(var c in cBox)
            {
                if (c.Checked == true)
                    summary += c.Text + " ";
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
