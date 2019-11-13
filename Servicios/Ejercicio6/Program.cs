using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        public static readonly object l = new Object();
        static Random aleatorio = new Random();
        static Thread[] hilos = new Thread[3];
        public static int contador = 0;
        public static int metaMinimo = -20;
        public static int metaMaximo = 20;
        public static bool finish = false;
        public static bool corriendo = false;
        public static int getNumber()
        {
            return aleatorio.Next(1, 11);
        }
        public static int getNumber(int num)
        {
            return aleatorio.Next(100, 100*num);
        }
        public static void turno(int pos,int player)
        {
            int aux;
            while (!finish)
            {
                lock (l)
                {
                    if (!finish)
                    {
                        if(contador<=metaMinimo || contador >= metaMaximo)
                        {
                            finish = true;
                            Console.SetCursorPosition(5, 10);
                            Console.Write("Finalizado"+contador);
                            Console.ReadKey();
                            return;
                        }
                        aux = getNumber();
                        Console.SetCursorPosition(5, pos);
                        Console.Write(aux);
                        Thread.Sleep(getNumber(aux));
                        if (aux == 5 || aux == 7)
                        {
                            switch (player)
                            {
                                case 1:
                                    if (!corriendo)
                                    {
                                        contador += 5;
                                    }
                                    else
                                    {
                                        contador++;
                                    }
                                    corriendo = false;
                                    //Console.SetCursorPosition(5, 10);
                                    //Console.Write("Parado***");
                                    break;
                                case 2:
                                    if (corriendo)
                                    {
                                        contador += 5;
                                    }
                                    else
                                    {
                                        contador++;
                                    }
                                    corriendo = true;
                                    //Console.SetCursorPosition(5, 10);
                                    //Console.Write("En marcha");
                                    break;
                            }
                        }
                        Console.SetCursorPosition(10, 5);
                        Console.Write(contador);
                    }
                }
            }
        }
        public static void cambioColor()
        {
            int temp = 0;
            int cont = 0;
            while (!finish)
            {
                lock (l)
                {
                    if (!finish && corriendo)
                    {
                        temp++;
                        //Console.SetCursorPosition(3, 10);
                        //Console.Write(temp);
                        if (temp > 2)
                        {
                            temp = 0;
                            cont++;
                            Console.SetCursorPosition(40, 10);
                            Console.Write("Cambio de color "+cont);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            hilos[0] = new Thread(() => turno(0,1));
            hilos[1] = new Thread(() => turno(20,2));
            hilos[2] = new Thread(() => cambioColor());

            for(int i=0; i<hilos.Length; i++)
            {
                hilos[i].Start();
                corriendo = true;
            }
        }
    }
}
