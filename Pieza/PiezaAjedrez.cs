using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public interface IPiezaAjedrez
    {
       


        public bool PuedeComer(IPiezaAjedrez otraPieza, Tablero tablero);

       
       

        public string Representacion { get; } // Propiedad para la representación en el tablero

    }
}