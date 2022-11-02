using Animales.Animales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacionAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(10,11,12,"Rojo");
           
            MessageBox.Show(loro.ImprimirComida());
        }

        private void btnLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(5, 38, 55, "Macho");
           
            MessageBox.Show(leon.ImprimirComida());
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(8, 20, 22, 23);
            
            MessageBox.Show(conejo.ImprimirComida());
        }
    }
}
