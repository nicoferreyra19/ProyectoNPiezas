using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezas
{
    public class Tablero
    {
        private IPiezaAjedrez[,] casillas;

        public Tablero()
        {
            casillas = new IPiezaAjedrez[8, 8];
        }

        public void ColocarPieza(IPiezaAjedrez pieza, int x, int y)
        {
            casillas[x, y] = pieza;
        }

        public void MostrarTablero()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (casillas[x, y] == null)
                    {
                        Console.Write(" - "); // Casilla vacía
                    }
                    else
                    {
                        Console.Write(" " + casillas[x, y].Representacion + " "); // Representación de la pieza
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
