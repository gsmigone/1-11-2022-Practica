﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaAjedrez.Models;

namespace WindowsPresentacionAjedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMuePeo_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();
            MessageBox.Show(peon.Mover());
        }

        private void btnMueTor_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            MessageBox.Show(torre.Mover());
        }

        private void btnMueCab_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.Mover());
        }
    }
}
