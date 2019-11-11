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
        public static int metaMinimo = 0;
        public static int metaMaximo = 0;
        public static bool finish = false;
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
                        if(contador<=-metaMinimo || contador >= metaMaximo)
                        {
                            finish = true;
                        }
                        aux = getNumber();
                        Console.SetCursorPosition(pos, 10);
                        Console.Write(aux);
                        Thread.Sleep(getNumber(aux));
                        if (aux == 5 || aux == 7)
                        {
                            switch (player)
                            {
                                case 1:
                                   
                                    break;
                                case 2:

                                    break;
                            }
                        }
                    }
                }
            }
        }
        public static void cambioColor()
        {
            while (!finish)
            {
                lock (l)
                {
                    if (!finish)
                    {

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
            }
        }
    }
}
