using LibreriaAjedrez.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Models
{
    public class Peon : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Mueve hacia adelante o come en diagonal";
        }
    }
}
