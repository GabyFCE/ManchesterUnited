using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManchesterUnited
{
    internal static class AnalisisJugador
    {

        public static void RevisarJugador()
        {
            List<Player> jugadores = GenerarLista();
            while (true)
            {
                Console.WriteLine("Ingrese el numero de camiseta del jugador a evaluar");
                string ingreso = Console.ReadLine();
                bool eval = int.TryParse(ingreso, out int camiseta);

                if (!eval) 
                {
                    Console.WriteLine("Debe ingresar un número entero");
                    continue;
                }
                if (camiseta < 1)
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                if(!jugadores.Any(j => j.JerseyNumber == camiseta))
                {
                    Console.Clear();
                    Console.WriteLine("No Existe jugadores con esa camiseta.");
                    Console.ReadKey();
                    break;
                }

                foreach (Player p in jugadores)
                {
                    if(p.JerseyNumber == camiseta)
                    {
                        Console.Clear();
                        Console.WriteLine("Estadisticas de " + p.NombreApellido.ToString() + ":");
                        Console.WriteLine("Camiseta: " + p.JerseyNumber);
                        Console.WriteLine("Goles: " + p.Goals.ToString());
                        Console.WriteLine("Velocidad: " + p.PointsInSpeed.ToString());
                        Console.WriteLine("Asistencia: " + p.PointsInAssist.ToString());
                        Console.WriteLine("Exactitud en los pases: " + p.PointsInPassingAccuracy.ToString());
                        Console.WriteLine("Involucramiento defensivo: " + p.DefensiveInvolvements.ToString());
                        Console.ReadKey();

                    }
                }
                break;

            }


        }
        public static void ComprararJugadores()
        {
            List<Player> jugadores = GenerarLista();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el numero de camiseta del primer jugador a evaluar");
                string ingreso1 = Console.ReadLine();
                bool eval1 = int.TryParse(ingreso1, out int camiseta1);

                if (!eval1)
                {
                    Console.WriteLine("Debe ingresar un número entero");
                    continue;
                }
                if (camiseta1 < 1)
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                if (!jugadores.Any(j => j.JerseyNumber == camiseta1))
                {
                    Console.Clear();
                    Console.WriteLine("No Existe jugadores con esa camiseta.");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Ingrese el numero de camiseta del segundo jugador a evaluar");
                string ingreso2 = Console.ReadLine();
                bool eval2 = int.TryParse(ingreso2, out int camiseta2);

                if (!eval2)
                {
                    Console.WriteLine("Debe ingresar un número entero");
                    continue;
                }
                if (camiseta2 < 1)
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                if (!jugadores.Any(j => j.JerseyNumber == camiseta2))
                {
                    Console.Clear();
                    Console.WriteLine("No Existe jugadores con esa camiseta.");
                    Console.ReadKey();
                    break;
                }


                foreach (Player p in jugadores)
                {
                    if (p.JerseyNumber == camiseta1)
                    {
                        Console.Clear();
                        Console.WriteLine("Estadisticas de " + p.NombreApellido.ToString() + ":");
                        Console.WriteLine("Camiseta: " + p.JerseyNumber);
                        Console.WriteLine("Goles: " + p.Goals.ToString());
                        Console.WriteLine("Velocidad: " + p.PointsInSpeed.ToString());
                        Console.WriteLine("Asistencia: " + p.PointsInAssist.ToString());
                        Console.WriteLine("Exactitud en los pases: " + p.PointsInPassingAccuracy.ToString());
                        Console.WriteLine("Involucramiento defensivo: " + p.DefensiveInvolvements.ToString());
                        Console.WriteLine("\n" + "\n");

                    }
                }
                foreach (Player p in jugadores)
                {
                    if (p.JerseyNumber == camiseta2)
                    {
                        Console.WriteLine("Estadisticas de " + p.NombreApellido.ToString() + ":");
                        Console.WriteLine("Camiseta: " + p.JerseyNumber);
                        Console.WriteLine("Goles: " + p.Goals.ToString());
                        Console.WriteLine("Velocidad: " + p.PointsInSpeed.ToString());
                        Console.WriteLine("Asistencia: " + p.PointsInAssist.ToString());
                        Console.WriteLine("Exactitud en los pases: " + p.PointsInPassingAccuracy.ToString());
                        Console.WriteLine("Involucramiento defensivo: " + p.DefensiveInvolvements.ToString());
                        Console.ReadKey();

                    }
                }

                break;

            }
        }

        public static void IdentificarRapidez()
        {
            int aux = 0;
            List<Player> jugadores = GenerarLista();
            foreach (Player p in jugadores)
            {
                if (p.PointsInSpeed > aux)
                {
                    aux = p.PointsInSpeed;

                }
            }
            foreach (Player p in jugadores)
            {
                if (p.PointsInSpeed == aux)
                {
                    Console.Clear();
                    Console.WriteLine("El jugador con mayor puntaje en velocidad es: " + p.NombreApellido.ToString());
                    Console.ReadKey();
                }
            }

        }
        public static void IdentificarMasGoleador()
        {
            int aux = 0;
            List<Player> jugadores = GenerarLista();
            foreach (Player p in jugadores)
            {
                if (p.Goals > aux)
                {
                    aux = p.Goals;

                }
            }
            foreach (Player p in jugadores)
            {
                if (p.Goals == aux)
                {
                    Console.Clear();
                    Console.WriteLine("El jugador más goleador es: " + p.NombreApellido.ToString());
                    Console.ReadKey();
                }
            }

        }
        public static void IdentificarMasAsistidor()
        {
            int aux = 0;
            List<Player> jugadores = GenerarLista();
            foreach (Player p in jugadores)
            {
                if (p.PointsInAssist > aux)
                {
                    aux = p.PointsInAssist;

                }
            }
            foreach (Player p in jugadores)
            {
                if (p.PointsInAssist == aux)
                {
                    Console.Clear();
                    Console.WriteLine("El jugador más asistidor es: " + p.NombreApellido.ToString());
                    Console.ReadKey();
                }
            }

        }
        public static void IdentificarMasCertero()
        {
            int aux = 0;
            List<Player> jugadores = GenerarLista();
            foreach (Player p in jugadores)
            {
                if (p.PointsInPassingAccuracy > aux)
                {
                    aux = p.PointsInPassingAccuracy;

                }
            }
            foreach (Player p in jugadores)
            {
                if (p.PointsInPassingAccuracy == aux)
                {
                    Console.Clear();
                    Console.WriteLine("El jugador más certero en pases es: " + p.NombreApellido.ToString());
                    Console.ReadKey();
                }
            }
        }

        public static void IdentificarMasDefensivo()
        {
            int aux = 0;
            List<Player> jugadores = GenerarLista();
            foreach (Player p in jugadores)
            {
                if (p.DefensiveInvolvements > aux)
                {
                    aux = p.DefensiveInvolvements;

                }
            }
            foreach (Player p in jugadores)
            {
                if (p.DefensiveInvolvements == aux)
                {
                    Console.Clear();
                    Console.WriteLine("El jugador más defensivo: " + p.NombreApellido.ToString());
                    Console.ReadKey();
                }
            }
        }

        private static List<Player> GenerarLista()
        {

            /**
            Bruno Fernandes: 5 goals, 6 points in speed, 9 points in assists, 10 points in passing accuracy, 3 defensive involvements. Corresponds to jersey number 8.
            Rasmus Hojlund: 12 goals, 8 points in speed, 2 points in assists, 6 points in passing accuracy, 2 defensive involvements. Corresponds to jersey number 11.
            Harry Maguire: 1 goal, 5 points in speed, 1 point in assists, 7 points in passing accuracy, 9 defensive involvements. Corresponds to jersey number 5.
            Alejandro Garnacho: 8 goals, 7 points in speed, 8 points in assists, 6 points in passing accuracy, 0 defensive involvements. Corresponds to jersey number 17.
            Mason Mount: 2 goals, 6 points in speed, 4 points in assists, 8 points in passing accuracy, 1 defensive involvement

            **/

            Player BrunoFernandez = new Player("Bruno Fernandez", 8, 5, 6, 9, 10, 3);
            Player RasmusHojlund = new Player("Rasmus Hojlund", 11, 12, 8, 2, 6, 2);
            Player HarryMaguire = new Player("Harry Maguire", 5, 1, 5, 1, 7, 9);
            Player AlejandroGarnacho = new Player("Alejandro Garnacho", 17, 8, 7, 8, 6, 0);
            Player MasonMount = new Player("Mason Mount", 7, 2, 6, 4, 8, 1);
            List<Player> jugadores = new List<Player>() 
            {
                BrunoFernandez, RasmusHojlund, HarryMaguire, AlejandroGarnacho, MasonMount
            };


            return jugadores;
        }
    }
}
