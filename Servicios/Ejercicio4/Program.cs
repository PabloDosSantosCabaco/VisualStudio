using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class CaballoNotFoundException : Exception { }
    class Program
    {
        static readonly private object l = new object();
        const int cantidad = 10;
        const int meta = 80;
        static Thread[] hilos = new Thread[cantidad];
        static int[] avances = new int[cantidad];
        static bool fin;
        static bool apuestaCorrecta;
        static Random aleatorio = new Random();
        public static int apuesta;
        static void Main(string[] args)
        {
            do
            {
                lock (l)
                {
                    fin = false;
                    do
                    {
                        apuestaCorrecta = false;
                        Console.WriteLine("¿A qué caballo desea apostar?");
                        for (int i = 1; i <= cantidad; i++)
                        {
                            Console.Write("Caballo " + (i) + "\t");
                            if (i % 5 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        try
                        {
                            apuesta = Convert.ToInt32(Console.ReadLine());
                            if (apuesta <= 0 || apuesta > cantidad)
                            {
                                throw new CaballoNotFoundException();
                            }
                            apuestaCorrecta = true;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Caballo inexistente.");
                        }
                        catch (CaballoNotFoundException)
                        {
                            Console.WriteLine("Caballo inexistente.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Tipo de dato no válido.");
                        }
                    } while (!apuestaCorrecta);
                    Console.Clear();
                    Console.WriteLine("QUE EMPIECE LA CARRERA");
                    Console.WriteLine("Ha apostado por el caballo " + apuesta);
                    for (int i = 0; i < hilos.Length; i++)
                    {
                        int aux = i;
                        hilos[i] = new Thread(() => Avanzar(aux));
                    }
                    for (int i = 0; i < hilos.Length; i++)
                    {
                        hilos[i].Start();
                    }

                    Monitor.Wait(l);
                    Console.WriteLine("¿Desea volver a jugar?\n1.-Si\n2.-No");
                    try
                    {
                        apuesta = Convert.ToInt32(Console.ReadLine());
                        switch (apuesta)
                        {
                            case 1:
                                fin = false;
                                break;
                            case 2:
                                fin = true;
                                break;
                            default:
                                Console.WriteLine("Dato incorrecto. Se saldrá del juego.");
                                fin = true;
                                Console.ReadKey();
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Dato incorrecto. Se saldrá del juego.");
                        Console.ReadKey();
                    }
                }
            } while (!fin) ;
        }

        public static void Avanzar(int hilo)
        {
            int pos = 0;
            while (!fin)
            {
                lock (l)
                {
                    if (!fin)
                    {
                        pos +=  aleatorio.Next(1,3);
                        Console.SetCursorPosition(pos, hilo+3);
                        Console.Write("*");
                        if (pos >= meta)
                        {
                            Console.SetCursorPosition(0, hilos.Length + 3);
                            Console.WriteLine("Ha ganado el caballo "+(hilo+1));
                            Monitor.Pulse(l);
                            if (hilo + 1 == apuesta)
                            {
                                Console.WriteLine("¡Enhorabuena!");
                            }
                            else
                            {
                                Console.WriteLine("Que lástima....");
                            }
                            fin = true;
                        }
                    }
                }
                Thread.Sleep( aleatorio.Next(20, 101));
            }
        }
    }
}
