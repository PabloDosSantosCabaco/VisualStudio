using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static readonly private object l = new object();
        const int cantidad = 7;
        const int meta = 80;
        static Thread[] hilos = new Thread[cantidad];
        static int[] avances = new int[cantidad];
        static bool fin = false;
        static Random aleatorio = new Random();
        public static int apuesta;
        static void Main(string[] args)
        {
            Console.WriteLine("¿A qué caballo desea apostar?");
            for(int i=0; i<cantidad; i++)
            {
                Console.Write("Caballo "+(i+1)+"\t");
                if (i % 4 == 0 && i!=0)
                {
                    Console.WriteLine();
                }
            }
            try
            {
                apuesta = Convert.ToInt32(Console.ReadLine());
                if (apuesta <= 0 || apuesta > cantidad)
                {
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Caballo inexistente.");
            }
            catch ()
            {

            }
            for (int i = 0; i < hilos.Length; i++)
            {
                int aux = i;
                hilos[i] = new Thread(() => Avanzar(aux));
            }
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i].Start();
            }


            Console.ReadKey();
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
                            fin = true;
                        }
                    }
                }
                Thread.Sleep( aleatorio.Next(20, 101));
            }
        }
    }
}
