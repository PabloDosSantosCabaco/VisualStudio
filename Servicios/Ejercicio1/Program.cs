using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static bool exit = false;
        public delegate void MyDelegate();
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }
        static void salir()
        {
            Console.WriteLine("Adios");
            exit = true;
        }

        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
                    new MyDelegate[] { f1, f2, f3 });

            Console.ReadKey();
        }
        public static void MenuGenerator(String[] options, MyDelegate[] delegates)
        {
            do
            {
                if (options.Length != delegates.Length)
                {
                    Console.WriteLine("Invalid menu.");
                    exit = true;
                }
                else
                {
                    int count = 1;
                    foreach (var option in options)
                    {
                        Console.Write(count + ".-");
                        Console.WriteLine(option);
                        count++;

                    }
                    Console.WriteLine(count + ".-Exit");
                    int opt;
                    try
                    {
                        opt = Convert.ToInt32(Console.ReadLine());
                        if (opt <= 0 || opt > count)
                        {
                            Console.WriteLine("Incorrect value. Please, choose a number of the list.");
                        }
                        else if (opt == count)
                        {
                            salir();
                        }
                        else
                        {
                            delegates[opt - 1]();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect value. Please, choose a number of the list.");
                    }
                }
            } while (!exit);

        }
    }
}
