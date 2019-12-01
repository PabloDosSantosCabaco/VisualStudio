using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos_5
{
    class Program
    {
        static int counter = 0;
        static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            MyTimer t = new MyTimer(increment);
            t.Interval = 1000;
            string op = "";
            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.start();
                Console.WriteLine("Press any key to stop.");
                Console.ReadKey();
                t.stop();
                Console.WriteLine("Press 1 to restart or Enter to end.");
                op = Console.ReadLine();
            } while (op == "1");
            t.salir();
        }
    }

    class MyTimer
    {
        readonly object l = new object();
        int interval;
        bool avance = false;
        bool finish = false;
        public int Interval { get; set; }
        public delegate void MyDelegate();
        public MyTimer(MyDelegate del)
        {
            Thread hilo = new Thread(()=> {
                while (!finish)
                {
                    lock (l)
                    {
                        if (!avance)
                        {
                            Monitor.Wait(l);
                        }
                        else
                        {
                            del();
                        }
                    }
                    Thread.Sleep(Interval);
                }
            });
            hilo.Start();
        }
        public void start()
        {
            lock (l)
            {
                Monitor.Pulse(l);
                avance = true;
            }
        }
        public void stop()
        {
            avance = false;
        }
        public void salir()
        {
            lock (l)
            {
                finish = true;
                Monitor.Pulse(l);
            }
        }
    }
}
