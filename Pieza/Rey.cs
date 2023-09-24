using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Rey : IPiezaAjedrez
    {


        public bool PuedeComer(IPiezaAjedrez otraPieza)
        {
            // Un rey puede moverse una casilla en cualquier dirección, por lo que puede comer a cualquier pieza cercana

            return true;
        }

        public string Representacion {
              
            get { }
        }           

    }
}
