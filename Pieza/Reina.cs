using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Reina : IPiezaAjedrez
    {
        int x1;
        int y1;
        int x2; 
        int y2;

        public bool PuedeComer(IPiezaAjedrez otraPieza, Tablero tablero)
        {
            if (EsMismaFila(x1, x2) || EsMismaColumna(y1, y2) || EsMismaDiagonal(x1, y1, x2, y2))
            {
                // Verifica si no hay obstáculos en el camino
                if (!HayObstaculos(x1, y1, x2, y2, otraPieza, tablero))
                {
                    return true; // La reina puede comer a la otra pieza
                }
            }
            return false;
        }

        public string Representacion
        {
            get { return "R"; }
        }

        private bool EsMismaFila(int x1, int x2)
        {
            return x1 == x2;
        }

        public bool EsMismaColumna(int y1, int y2)
        {
            return y1 == y2;
        }
        public bool EsMismaDiagonal(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        }

        public bool HayObstaculos(int x1, int y1, int x2, int y2, IPiezaAjedrez otraPieza, Tablero tablero)
        {
            int deltaX = Math.Sign(x2 - x1); // Dirección horizontal
            int deltaY = Math.Sign(y2 - y1); // Dirección vertical

            int x = x1 + deltaX; // Iniciar desde la siguiente casilla
            int y = y1 + deltaY;

            while (x != x2 || y != y2)
            {
                // Verificar si hay una pieza en la casilla actual
                if (tablero != null)
                {
                    return true; // Hay un obstáculo en el camino
                }

                // Mover a la siguiente casilla en la dirección
                x += deltaX;
                y += deltaY;
            }

            return false; // No hay obstáculos en el camino
        }
    }
}
