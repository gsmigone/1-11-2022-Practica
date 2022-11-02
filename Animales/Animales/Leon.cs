using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public class Leon : Animal
    {
        public Leon(int edad, decimal altura, decimal peso, string sexo) : base(edad, altura, peso)
        {
            Sexo = sexo;
        }

        public string Sexo { get; set; }
        public override string ImprimirComida()
        {
            return "Come Carne";
        }
    }
}
