using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Caballo : IPiezaAjedrez
    {
        

        public bool PuedeComer(IPiezaAjedrez otraPieza)
        {
            // Un caballo puede comer a otra pieza si se encuentra en una de las casillas posibles en L

            return true;
        }

        public string Representacion
        {
            get { }
        }
    }
}
