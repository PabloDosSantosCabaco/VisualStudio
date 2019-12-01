using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos_6
{
    class Program
    {
        int meta1 = 20;
        int meta2 = -20;
        int contador = 0;
        bool pausa = false;
        static readonly object l = new object();
        Random number = new Random();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread player1 = new Thread(()=> {
                int num=1;
                while (p.contador < p.meta1 && p.contador>p.meta2)
                {
                    lock (l)
                    {
                        num = p.number.Next(1, 11);
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine($"{num,2}");
                        if ((num == 5 || num == 7) && p.pausa)
                        {
                            p.contador += 5;
                        }
                        else if (num == 5 || num == 7)
                        {
                            p.contador++;
                            p.pausa = true;
                        }
                        Console.SetCursorPosition(1, 5);
                        Console.WriteLine($"{p.contador,3}");
                    }
                    Thread.Sleep(p.number.Next(100, 100 * num));
                }
            });
            Thread player2 = new Thread(() => {
                int num = 1;
                while (p.contador > p.meta2 && p.contador < p.meta1)
                {
                    lock (l)
                    {
                        num = p.number.Next(1, 11);
                        Console.SetCursorPosition(1, 10);
                        Console.WriteLine($"{num,2}");
                        if ((num == 5 || num == 7) && !p.pausa)
                        {
                            p.contador -= 5;
                        }
                        else if (num == 5 || num == 7)
                        {
                            p.pausa = false;
                            p.contador--;
                        }
                        Console.SetCursorPosition(1, 5);
                        Console.WriteLine($"{p.contador,3}");
                    }
                    Thread.Sleep(p.number.Next(100, 100 * num));
                }
            });
            Thread display = new Thread(()=> {
                bool color = false;
                while (p.contador<p.meta1 && p.contador > p.meta2)
                {
                    lock (l)
                    {
                        if (!p.pausa)
                        {
                            Console.SetCursorPosition(20, 5);
                            Console.BackgroundColor = color ? ConsoleColor.Red : ConsoleColor.Yellow;
                            color = !color;
                            Console.Write("ETIQUETA");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    Thread.Sleep(200);
                }
            });
            player1.Start();
            player2.Start();
            display.Start();
            Console.ReadKey();

        }
    }
}
