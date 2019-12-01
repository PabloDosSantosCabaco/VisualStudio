using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos_4
{
    class Program
    {
        bool finish = false;
        int meta = 100;
        int numeroCaballos = 5;
        Random number = new Random();
        static readonly object l = new object();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread[] caballos = new Thread[p.numeroCaballos];
            for(int i=0; i<caballos.Length; i++)
            {
                int aux = i;
                caballos[aux] = new Thread(()=> {
                    p.avanzar(aux);
                });
            }
            Array.ForEach(caballos, (caballo) => { caballo.Start(); });
            Array.ForEach(caballos, (caballo) => { caballo.Join(); });
            Console.ReadKey();
        }
        public void avanzar(int caballo)
        {
            int pos = 0;
            while (!finish)
            {
                lock (l)
                {
                    if (!finish)
                    {
                        int aux = number.Next(1, 3);
                        Console.SetCursorPosition(pos, caballo);
                        for(int i=0; i<aux; i++)
                        {
                            Console.Write("*");
                        }
                        pos += aux;
                        if (pos >= meta)
                        {
                            finish = true;
                            Console.SetCursorPosition(0, numeroCaballos);
                            Console.Write($"Ha ganado el caballo {caballo}");
                        }
                    }
                }
                Thread.Sleep(number.Next(1, 500));
            }
        }
    }
}
