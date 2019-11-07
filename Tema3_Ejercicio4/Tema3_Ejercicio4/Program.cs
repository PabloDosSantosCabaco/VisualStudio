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
            string cadena = "* * 2 10";
            string[] datos = cadena.Split((char)32);
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
            int[] newnums = new int[nums.Count];
            for(int i=0; i<newnums.Length; i++)
            {
                newnums[i] = nums[i];
            }
            if (correct)
            {
                switch (datos[0])
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
