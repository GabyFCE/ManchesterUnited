using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchesterUnited
{
    internal static class Menu
    {
        public static void Mostrar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese una opción" + "\n" + "\n");
                Console.WriteLine("1-Evaluación de jugador");
                Console.WriteLine("2-Comparar dos jugadores");
                Console.WriteLine("3-Jugador más rapido");
                Console.WriteLine("4-Jugador con más goles");
                Console.WriteLine("5-Jugador con más asistencias");
                Console.WriteLine("6-Jugador más certero en pases");
                Console.WriteLine("7-Jugador con más involucramientos defensivos");
                Console.WriteLine("8-Salir");

                string ingreso = Console.ReadLine();
                bool eval = int.TryParse(ingreso, out int val);
                if(!eval) 
                {
                    Console.WriteLine("Ingrese un número entero");
                    continue;
                }
                if(val < 1 || val > 8)
                {
                    Console.WriteLine("Ingrese un valor de 1 a 8");
                    continue;
                }
                switch(val)
                {
                    case 1: 
                        AnalisisJugador.RevisarJugador();
                        break;
                    case 2: 
                        AnalisisJugador.ComprararJugadores(); 
                        break;
                    case 3:
                        AnalisisJugador.IdentificarRapidez();
                        break;
                    case 4:
                        AnalisisJugador.IdentificarMasGoleador();
                        break;
                    case 5:
                        AnalisisJugador.IdentificarMasAsistidor();
                        break;
                    case 6:
                        AnalisisJugador.IdentificarMasCertero();
                        break;
                    case 7:
                        AnalisisJugador.IdentificarMasDefensivo();
                        break;
                    case 8:
                        return;

                }
            }
        }
    }
}
