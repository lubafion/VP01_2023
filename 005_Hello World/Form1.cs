﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Hello_World
{
    public partial class Form1 : Form
    {
        Color defaultFormColor;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            defaultFormColor = this.BackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == defaultFormColor)
            {
                this.BackColor = Color.Blue;
                label1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = defaultFormColor;
                label1.ForeColor = Color.Black;
            }
        }

       
    }
}
