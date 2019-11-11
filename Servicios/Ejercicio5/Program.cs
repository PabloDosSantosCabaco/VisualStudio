using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5
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
            t.Intervalo = 1000;
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
        }

        class MyTimer
        {
            public static readonly object l = new object();
            public delegate void MyDelegate();
            private int intervalo;
            public bool finish = false;
            public bool espera = true;
            public int Intervalo { get; set; }
            Thread hilo;
            public MyTimer(MyDelegate del)
            {
                hilo = new Thread(()=>
                    {
                        while (!finish)
                        {
                            Thread.Sleep(Intervalo);
                            lock (l)
                            {
                                if (espera)
                                {
                                    Monitor.Wait(l);
                                }else
                                {
                                    del();
                                }
                            }
                        };
                    });
                hilo.Start();
                lock (l)
                {
                    Monitor.Pulse(l);
                }
            }
            public void start() {
                finish = false;
                espera = false;
                lock (l)
                {
                    Monitor.Pulse(l);
                }
            }
            public void stop()
            {
                finish = true;
                espera = true;
                
            }
        }
    }
}
