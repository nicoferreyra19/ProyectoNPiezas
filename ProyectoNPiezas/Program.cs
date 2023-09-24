using System;
using System.Collections.Generic;
using System.Numerics;
using Piezas;

class Program
{
    static void Main()
    {
        Tablero tablero = new();

        List<IPiezaAjedrez> piezas = new();

        Solucion solucion = new();
        Peon peon = new();

        solucion.Resolver8Piezas(peon, tablero);

        

        // Mostrar el tablero
        tablero.MostrarTablero();

        
    }

    
    
}




