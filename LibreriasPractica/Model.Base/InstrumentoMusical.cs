using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasPractica.Model.Base
{
    public abstract class InstrumentoMusical
    {
        public string Nombre { get; set; }
        public abstract string Afilar();
        
    }
}
