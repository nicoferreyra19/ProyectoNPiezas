using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Torre : IPiezaAjedrez
    {
        

        public  bool PuedeComer(IPiezaAjedrez otraPieza)
        {
            // Una torre puede comer a otra pieza si se encuentra en la misma fila o columna
            return true; 
        }

        public string Representacion
        {
            get { }
        }

    }
}
