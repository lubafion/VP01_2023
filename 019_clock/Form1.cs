﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_clock
{
    public partial class Form1 : Form
    {
        bool aFlag = false; // 아날로그 시계를 표시하는 깃발
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000; //1초
            timer1.Tick += Timer1_Tick; //틱 이벤트 1초마다 반복
            label1.Font
                = new Font("맑은 고딕", 20, FontStyle.Bold);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (aFlag == false)
            {
                label1.Text = DateTime.Now.ToString();
                label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2, ClientSize.Height / 2 - label1.Height / 2);
            }
            
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 디지털시계ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aFlag = false;
        }

        private void 아날로그시계ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            aFlag = true;
        }
    }
}
