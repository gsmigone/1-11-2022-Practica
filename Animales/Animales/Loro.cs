using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public class Loro : Animal
    {
        public Loro(int edad, decimal altura, decimal peso, string colorpluma) : base(edad, altura, peso)
        {
            ColorPluma = colorpluma;
        }

        public string ColorPluma { get; set; }

        public override string ImprimirComida()
        {
            return "Come Semillas";
        }
    }
}
