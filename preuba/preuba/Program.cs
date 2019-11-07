using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preuba
{
    class Perro
    {
        public string raza;
        public string nombre;

        private int edad;
        // Nota: aunque lo veas así en este ejemplo,
        // en C# NO haremos el set y el get de esta forma.
        // La correcta se explica en un apartado posterior.
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public Perro()
        {
            this.setEdad(0);
            this.raza = "";
            this.nombre = "";
        }
    }
    class Program
    {
        static void Main()
        {
            Perro objPerro = new Perro();
            objPerro.raza = "Mastín";
            objPerro.nombre = "Laika";
            objPerro.setEdad(5);
            Console.WriteLine(objPerro.getEdad());
            Console.ReadLine();
        }
    }
}
