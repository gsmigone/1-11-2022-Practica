using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriasPractica.Model;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfiVio_Click(object sender, EventArgs e)
        {
            Violin violin = new Violin();
            MessageBox.Show(violin.Afilar());
        }

        private void btnAfiPia_Click(object sender, EventArgs e)
        {
            Piano piano = new Piano();
            MessageBox.Show(piano.Afilar());
        }

        private void btnAfiGui_Click(object sender, EventArgs e)
        {
            Guitarra gui = new Guitarra();
            MessageBox.Show(gui.Afilar());
        }
    }
}
