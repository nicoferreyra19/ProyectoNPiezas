using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Alfil : IPiezaAjedrez
    {
        public Alfil(int x, int y) { }

        public bool PuedeComer(IPiezaAjedrez otraPieza)
        {
            // Un alfil puede comer a una pieza si se encuentra en la misma diagonal
            return true;
        }

        public string Representacion
        {
            get { }
        }
    }
}
