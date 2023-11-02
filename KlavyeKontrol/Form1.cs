﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlavyeKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if(e.KeyCode == Keys.Right && x<937)
            {
                x = x + 5;
            }
            if(e.KeyCode == Keys.Left && x>12)
            {
                x = x - 5;
            }
            if (e.KeyCode == Keys.Up && y> 12)
            {
                y = y - 5;
            }
            if(e.KeyCode== Keys.Down && y< 514)
            {
                y = y + 5;
            }
            pictureBox1.Location = new Point(x,y);
        }
    }
}
