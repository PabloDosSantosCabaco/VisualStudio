using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "* 3 2 10";
            string[] datos = args; // cadena.Split((char)32);
            gestionador(args[0],)
            List<int> nums = new List<int>();
            bool correct = true;
            for(int i=1; i<datos.Length; i++)
            {
                correct = comprobarEntero(datos[i]);
                if (!correct)
                {
                    break;
                }
                else
                {
                    nums.Add(Convert.ToInt32(datos[i]));
                }
            }
        }
        public static void gestionador(string simbolo, params int[] nums)
        {
            for (int i = 1; i < datos.Length; i++)
            {
                correct = comprobarEntero(datos[i]);
                if (!correct)
                {
                    break;
                }
                else
                {
                    nums.Add(Convert.ToInt32(datos[i]));
                }
            }
            int[] newnums = new int[nums.Length];
            for (int i = 0; i < newnums.Length; i++)
            {
                newnums[i] = nums[i];
            }
            switch (simbolo)
            {
                case "+":
                    Console.WriteLine(suma(newnums));
                    break;
                case "*":
                    Console.WriteLine(mult(newnums));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        public static bool comprobarSigno(string dato)
        {
            if (dato.Equals("+") || dato.Equals("*"))
            {
                return true;
            }
            return false;
        }
        public static bool comprobarEntero(string dato)
        {
            try
            {
                Convert.ToInt32(dato);
            }
            catch (FormatException)
            {
                return false;
            }catch(OverflowException)
            {
                return false;
            }
            return true;
        }
        public static int mult(params int[] nums)
        {
            int a = 1;
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
    }
}
