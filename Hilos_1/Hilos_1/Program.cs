using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos_1
{
    class Program
    {
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
        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
            new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        }

        public static void MenuGenerator(string[] opciones, MyDelegate[] del)
        {
            int opcion = 0;
            bool repetir = true;
            bool correcto = false; ;
            do
            {
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1,1}){opciones[i]}");
                }
                Console.WriteLine($"{opciones.Length + 1,1})Exit");
                do
                {
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                        correcto = true;
                        if (opcion < 1 || opcion > opciones.Length + 1)
                        {
                            Console.WriteLine("Por favor, escoja uno de los valores de la lista.");
                            correcto = false;
                        }
                        else if(opcion == opciones.Length+1)
                        {
                            repetir = false;
                            Console.WriteLine("Adios");
                        }
                        else
                        {
                            del[opcion - 1]();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("El valor introducido no es válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("El número introducido es demasiado grande.");
                    }
                }while(!correcto);
            }while (repetir) ;
        }
    }
}
