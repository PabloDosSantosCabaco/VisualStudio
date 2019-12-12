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
<<<<<<< Updated upstream
        bool firstTime = true;
        int limitMax = 20;
        int limitMin = -20;
=======
        int meta1 = 10;
        int meta2 = -10;
>>>>>>> Stashed changes
        static int N1 = 0;
        static int N2 = 0;
        int contador = 0;
        bool finish = false;
        bool pausa = false;
        bool finish = false;
        static readonly object l = new object();
        Random number = new Random();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread player1 = new Thread(()=> {
<<<<<<< Updated upstream
                p.jugador(1,ref N1);
            });
            Thread player2 = new Thread(() => {
                p.jugador(2,ref N2);
            });
            Thread displayThread = new Thread(()=> {
                p.display();
            });
            player1.Start();
            player2.Start();
            displayThread.Start();
            player1.Join();
            player2.Join();
            displayThread.Join();
            Console.ReadKey();

        }
        public void jugador(int jugador,ref int numero){
            while(!finish){
                lock(l){
                    numero = number.Next(1,11);
                  //  Console.SetCursorPosition(1,jugador);
                    Console.WriteLine($"{jugador}{numero,2}");
                    if (numero == 5 || numero == 7)
                    {
                        switch (jugador)
=======
                p.jugador(1,N1);
            });
            Thread player2 = new Thread(() => {
                p.jugador(2,N2);
            });
            Thread display = new Thread(()=> {
                bool color = false;
                while (!p.finish)
                {
                    lock (l)
                    {
                        if ((N2== 5 || N2 == 7) && !p.pausa)
                        {
                            p.contador -= 5;
                        }
                        else if (N2 == 5 || N2 == 7)
>>>>>>> Stashed changes
                        {
                            case 1:
                                contador=contador+ (pausa ? 5: 1);
                                pausa = true;
                                break;
                            case 2:
                                contador = contador-(!pausa && !firstTime? 5: 1);
                                pausa = false;
                                Monitor.Pulse(l);
                                break;
                        }
<<<<<<< Updated upstream
                    }
                    firstTime = false;
                    //   Console.SetCursorPosition(1, 5);
                    Console.WriteLine($"Contador: {contador,3}");
                    if (contador <= limitMin || contador >= limitMax)
                    {
                        finish = true;
                    }
                }
                Thread.Sleep(number.Next(100,100+numero));
            }

        }
        public void display(){
            bool color = false;
            while (contador < limitMax && contador > limitMin)
            {
                lock (l)
                {
                    if (contador < limitMax && contador > limitMin)
                    {
                      //  Console.SetCursorPosition(20, 5);
                        Console.BackgroundColor = color ? ConsoleColor.Red : ConsoleColor.Yellow;
                        color = !color;
                        Console.WriteLine("ETIQUETA");
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (pausa)
=======
                        if ((N1 == 5 || N1 == 7) && p.pausa)
                        {
                            p.contador += 5;
                        }
                        else if (N1 == 5 || N1 == 7)
                        {
                            p.contador++;
                            p.pausa = true;
                        }
                        if(p.contador<=p.meta2 || p.contador>=p.meta1){
                            p.finish = true;
                        }
                        if (!p.pausa)
>>>>>>> Stashed changes
                        {
                            Monitor.Wait(l);
                        }
                        
                    }
                }
                Thread.Sleep(200);
            }
        }

        public void jugador(int jugador,ref int numero){
            while (contador > meta2 && contador < meta1)
            {
                lock (l)
                {
                    numero = p.number.Next(1, 11);
                    Console.SetCursorPosition(1, jugador);
                    Console.WriteLine($"{num,2}");
                    
                }
                Thread.Sleep(p.number.Next(100, 100 * numero));
            }
        }
    }
}
