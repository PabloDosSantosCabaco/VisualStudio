using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static readonly private object l = new object();
        public delegate bool DelegadoComprobacion(int a, int b);
        static int num = 0, max = 300, min = -300;
        static bool finish = false;

        static string[] frases = { "Ha ganado la suma", "Ha ganado la resta" };
        static int[] cursorPosition = { 1, 20 };
        static int[] incremento = { 1, -1 };
        static DelegadoComprobacion suma = (num, max) => num >= max ;
        static DelegadoComprobacion resta = (num, min) => num <= min ;
        static void Main(string[] args)
        {

            Thread plus = new Thread(()=> { Proceso(suma,incremento[0],frases[0],cursorPosition[0],max); });
            Thread minux = new Thread(() => { Proceso(resta, incremento[1], frases[1], cursorPosition[1],min); });
            minux.Start();
            plus.Start();


            Console.ReadKey();

        }

        public static void Proceso(DelegadoComprobacion a, int inc, string s, int pos,int limit)
        {

            while (!finish)
            {
                lock (l)
                {
                    if (!finish)
                    {
                        num += inc;
                        Console.SetCursorPosition(1, pos);
                        Console.Write("{0,5}",num);
                        if (a(num, limit))
                        {
                            finish = true;
                            Console.SetCursorPosition(1, 10);
                            Console.Write(s);
                        }
                    }
                }
            }
        }
    }
}
