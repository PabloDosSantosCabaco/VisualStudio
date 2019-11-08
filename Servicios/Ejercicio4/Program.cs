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
        const int cantidad = 5;
        const int meta = 80;
        static Thread[] hilos = new Thread[cantidad];
        static int[] avances = new int[cantidad];
        static bool fin = false;
        static Random aleatorio = new Random();
        static void Main(string[] args)
        {
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
                        pos += aleatorio.Next(1,51);
                        Console.SetCursorPosition(pos, hilo);
                        Console.Write("*");
                        if (pos >= meta)
                        {
                            fin = true;
                        }
                    }
                }
                Thread.Sleep(aleatorio.Next(20, 101));
            }
        }
    }
}
