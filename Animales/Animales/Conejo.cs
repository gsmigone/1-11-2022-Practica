using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public class Conejo : Animal
    {
        public Conejo(int edad, decimal altura, decimal peso, decimal alturasalto) : base(edad, altura, peso)
        {
            AlturaSalto = alturasalto;
        }

        public decimal AlturaSalto { get; set; }

        public override string ImprimirComida()
        {
            return "Come Zanahoria";
        }
    }
}
