﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play fenetre = new Play();
            fenetre.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Application.Exit() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info fenetre = new Info();
            fenetre.ShowDialog();
        }
    }
}
