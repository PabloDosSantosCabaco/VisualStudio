using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            cadena = Console.ReadLine();
            string[] datos = cadena.Split((char)32);
            double[] num = new double[datos.Length - 1];
            try
            {
                for (int i = 0; i < num.Length; i++)
                    num[i] = Convert.ToDouble(datos[i + 1]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid args");
            }
                if (datos[0] == "+")
            {
                Console.WriteLine(suma(num));
            }
            else if (datos[0] == "*")
            {
                Console.WriteLine(mult(num));
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }
            Console.ReadKey();
        }
        public void leerDatos()
        {

        }
        public static int mult(params int[] nums)
        {
            int a = 1;
            for (int i = 0; i < nums.Length; i++)
                a *= nums[i];
            return a;
        }
        public static double mult(params double[] nums)
        {
            double a = 1;
            for (int i = 0; i < nums.Length; i++)
                a *= nums[i];
            return a;
        }
        public static int suma(params int[] nums)
        {
            int a = 0;
            for (int i = 0; i < nums.Length; i++)
                a += nums[i];
            return a;
        }
        public static double suma(params double[] nums)
        {
            double a = 0;
            for (int i = 0; i < nums.Length; i++)
                a += nums[i];
            return a;
        }
    }
}
