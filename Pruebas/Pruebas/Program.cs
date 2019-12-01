using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pruebas
{
    public delegate int Operation(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i < 'D'; i++)
 {
                char oneChar = i;
                /* Es necesario usar oneChar porque si uso i estoy usando el mismo i compartido para
                todas las funciones por lo que el mismo hilo puede estar mostrando distintas letras al
                evolucionar i. Sin embargo como oneChar se declara dentro del bucle, cada hilo tiene el
                suyo propio y no hay conflicto.
                Para ver el error sustituye en la lambda oneChar por i.*/
                new Thread(() =>
                {
                    for (int j = 0; j < 5; j++)
                        Console.Write(oneChar);
                }).Start();
            }
            Console.ReadKey();
        }
    }
}
