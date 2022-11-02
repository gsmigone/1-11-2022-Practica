using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriasPractica.Model.Base;

namespace LibreriasPractica.Model
{
    public class Piano:InstrumentoMusical
    {
        public override string Afilar()
        {
            return "Afilando " + Nombre;
        }
    }
}
