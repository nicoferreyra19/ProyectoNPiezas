using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Peon : IPiezaAjedrez
    {
        int x1;
        int y1;
        int x2; 
        int y2;

        public bool PuedeComer(IPiezaAjedrez otraPieza)
        {
            // Verifica si la distancia horizontal es de 1 casilla (movimiento diagonal)
            if (Math.Abs(x2 - x1) == 1)
            {
                // Verifica si la distancia vertical es de 1 casilla hacia arriba (si es peón blanco) o hacia abajo (si es peón negro)
                if ((y2 - y1 == 1) || (y1 - y2 == 1))
                {
                    // Verifica si no hay una pieza del mismo color en la casilla de destino
                    if (!EsMismaFila(x1, x2) && otraPieza != null)
                    {
                        return true; // El peón puede comer a la otra pieza
                    }
                }
            }

            return false; // El peón no puede comer a la otra pieza
        }

        public string Representacion { get { return "P"; } }

        private bool EsMismaFila(int x1, int x2)
        {
            return x1 == x2;
        }

    }
}