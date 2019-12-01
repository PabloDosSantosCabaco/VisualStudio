using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos_3
{
    class Program
    {
        int valor = 0;
        int limitUp = 1000;
        int limitDown = -1000;
        bool finish = false;
        static readonly object l = new object();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread[] hilos = new Thread[2];
            hilos[0] = new Thread(() => {
                while (!p.finish)
                {
                    lock (l)
                    {
                        if (!p.finish)
                        {
                            p.aumentar();
                            Console.SetCursorPosition(1, 1);
                            Console.WriteLine($"{p.valor,5}");
                            if (p.valor >= p.limitUp)
                            {
                                p.finish = true;
                            }
                        }
                    }
                }
            });
            hilos[1] = new Thread(() => {
                while (!p.finish)
                {
                    lock (l)
                    {
                        if (!p.finish)
                        {
                            p.decrementar();
                            Console.SetCursorPosition(1, 10);
                            Console.WriteLine($"{p.valor,5}");
                            if (p.valor <= p.limitDown)
                            {
                                p.finish = true;
                            }
                        }
                    }
                }
            });
            Array.ForEach(hilos, (hilo) => { hilo.Start(); });
            Console.ReadKey();
        }

        public void aumentar()
        {
            valor++;
        }
        public void decrementar()
        {
            valor--;
        }
    }
}
