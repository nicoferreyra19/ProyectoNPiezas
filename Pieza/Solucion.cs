using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Solucion
    {

        public void Resolver8Piezas(IPiezaAjedrez pieza, Tablero tablero)
        {
            for (int x = 0; x < 8; x++)
            {
                for(int y = 0; y < 8; y++) {
                    if (pieza.PuedeComer(pieza) == false)
                    {
                        tablero.ColocarPieza(pieza, x, y);
                    }
                }
                
                
            }

        }


    }
}
