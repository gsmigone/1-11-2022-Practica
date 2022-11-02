using LibreriaAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaAjedrez.Models
{
    public class Torre : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Mueve en linea recta";
        }
    }
}
