using LibreriaMedico.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMedico.Models
{
    public class Medico:Persona
    {
        public override string ToString()
        {
            return Nombre;
        }
    }
}
