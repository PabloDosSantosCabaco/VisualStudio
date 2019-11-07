using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Ejercicio3
{
    public class OutOfMenuRangeException : Exception { }

    public delegate void DelegateMenu();
    enum Tipo
    {
        Arcade,
        Videoaventura,
        Shootemup,
        Estrategia,
        Deportivo
    }
    class Videojuego
    {
        private string titulo;
        private int anho;
        private string estilo;
        public Videojuego(string titulo, int anho, string estilo)
        {
            Titulo = titulo;
            Anho = anho;
            if (Enum.IsDefined(typeof(Tipo), estilo))
            {
                Estilo = estilo;
            }
            else
            {
                Estilo = Tipo.Arcade.ToString();
            }
        }
        public string Estilo { get; set; }
        public string Titulo { get; set; }
        public int Anho { set; get; }
    }
    class GestorVideojuegos
    {
        public List<Videojuego> coleccion;
        public GestorVideojuegos()
        {
            coleccion = new List<Videojuego>();
            coleccion.Add(new Videojuego("Juego 1", 2002, "Arcade"));
            coleccion.Add(new Videojuego("Juego 2", 2001, "Deportivo"));
            coleccion.Add(new Videojuego("Juego 3", 2007, "Shootemup"));
        }
        public bool sortCollection()
        {
            List<Videojuego> newList = new List<Videojuego>();
            if (coleccion.Count <= 0)
            {
                return false;
            }
            do
            {
                int min = coleccion[0].Anho;
                int indice = 0;
                for (int i = 0; i < coleccion.Count; i++)
                {
                    if (min > coleccion[i].Anho)
                    {
                        min = coleccion[i].Anho;
                        indice = i;
                    }

                }
                newList.Add(coleccion[indice]);
                this.eliminar(indice, 1);
            } while (coleccion.Count > 0);
            coleccion = newList;
            return true;
            
        }
        public int posicion(int anho)
        {
            int result = 0;
            foreach(Videojuego juego in coleccion)
            {
                if (juego.Anho <= anho)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
        public bool eliminar(int min, int max)
        {
            try
            {
                coleccion.RemoveRange(min, max);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }
        public bool eliminar(int num)
        {
            return eliminar(0, num);
        }
        public List<Videojuego> busquedaEstilo(string estilo)
        {
                List<Videojuego> nuevaColeccion = new List<Videojuego>();
                foreach(Videojuego juego in coleccion)
                {
                    if (juego.Estilo == "estilo")
                    {
                        nuevaColeccion.Add(juego);
                    }
                }
                return nuevaColeccion;
        }
    }
    class MenuGenerator
    {
        static GestorVideojuegos gameList = new GestorVideojuegos();
        DelegateMenu[] delegates =
        {
            addGame, deleteGame, showGames, changeGame, exitApp
        };
        string[] menuOptions = new string[] { "Add Game","Delete Game","Show Games","Change Games", "Exit" };
        public static bool exit = false;
        public static void addGame()
        {
            string name, style;
            int year;
            try
            {
                    Console.Write("Introduce videogame's title: ");
                do
                {
                    name = Console.ReadLine();
                    if(name.Trim().Length == 0)
                    {
                        Console.WriteLine("Please, introduce videogame's title: ");
                    }
                } while (name.Trim().Length == 0);
                do
                {
                    Console.Write("Introduce year's game: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    if (year < 0)
                    {
                        Console.WriteLine("Years can't be negative for a videogame's date out.");
                    }
                } while (year < 0 || year.ToString().Trim().Length<=0);
                do
                {
                    showTipos();
                    Console.Write("Introduce style's game: ");
                    style = Console.ReadLine();
                    if (!Enum.IsDefined(typeof(Tipo), style))
                    {
                        Console.WriteLine("That videogame style is not defined in our database.");
                    }
                } while (!Enum.IsDefined(typeof(Tipo), style.Trim()));

                gameList.coleccion.Add(new Videojuego(name, year, style));
                gameList.sortCollection();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Something wrong just happens.");
                Console.WriteLine("Error: "+ex);
            }
            
        }
        public static void deleteGame()
        {
            int min = 0, max = 0;
            bool correct;
            string confirm = "";
            do
            {
                correct = true;
                showGames();
                Console.WriteLine("Introduce the first game you gonna delete: ");
                try
                {
                    min = Convert.ToInt32(Console.ReadLine());
                    if (min > gameList.coleccion.Count || min < 0)
                    {
                        Console.WriteLine("Invalid option. Doesn't exists that game.");
                        throw new InvalidValue();
                    }
                    Console.WriteLine("Introduce how many games you wanna delete from " + min + " including it: ");
                    max = Convert.ToInt32(Console.ReadLine());
                    if (min + max > gameList.coleccion.Count || max <= 0)
                    {
                        Console.WriteLine("Invalid option. You can't delete more games that already exists or don't delete someone.");
                        throw new InvalidValue();
                    }
                    Console.WriteLine("Games selected to delete:");           
                    for (int i = 0; i < max; i++)
                    {
                        Console.WriteLine("-" + gameList.coleccion[min + i].Titulo);
                    }
                    Console.WriteLine("Are you sure about delete this games?(S/N) You can't undo this action.");
                    confirm = Console.ReadLine().ToLower();
                    switch (confirm)
                    {
                        case "s":
                            if(gameList.eliminar(min, max))
                            {
                                Console.WriteLine("Games deleted.");
                            }
                            else
                            {
                                Console.WriteLine("Some error ocurred. Can't delete games.");
                            }
                            correct = true;
                            break;
                        case "n":
                            Console.WriteLine("No games deleted");
                            correct = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Operation canceled.");
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (InvalidValue)
                {
                    Console.WriteLine();
                }
            } while (!correct);
        }
        public static void showGames()
        {
            int maxLength = 15;
            if (!gameList.sortCollection())
            {
                Console.WriteLine("The collection is empty.");
            }
            else
            {
                for (int i = 0; i < gameList.coleccion.Count; i++)
                {
                    Console.WriteLine("Game " + i);
                    if (gameList.coleccion[i].Titulo.Length > maxLength)
                    {
                        Console.WriteLine("Title: " + gameList.coleccion[i].Titulo.Substring(0, maxLength - 3) + "...");
                    }
                    else
                    {
                        Console.WriteLine("Title: " + gameList.coleccion[i].Titulo);
                    }
                    Console.WriteLine("Year: " + gameList.coleccion[i].Anho);
                    Console.WriteLine("Genre: " + gameList.coleccion[i].Estilo);
                    if (i != gameList.coleccion.Count - 1)
                    {
                        Console.WriteLine("----------------------------");
                    }
                }
            }
        }
        public static void changeGame()
        {
            int opt;
            Console.WriteLine("What game do you want to change?");
            opt = Convert.ToInt32(Console.ReadLine());
            if(opt<0 || opt >= gameList.coleccion.Count)
            {
                Console.WriteLine("This game desn't exists in the current list.");
            }
            gameList.eliminar(opt, 1);
            addGame();
        }
        public static void exitApp()
        {
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
            exit = true;
        }
        public void menu()
        {
            int userOption = 0;
            do
            {
                int menuOption = 1;
                Console.WriteLine("----------------");
                foreach (var element in menuOptions)
                {
                    Console.WriteLine(menuOption + ".-" + element);
                    menuOption++;
                }
                Console.WriteLine("----------------");
                try
                {
                    userOption = Convert.ToInt32(Console.ReadLine());
                    if (userOption < 1 || userOption >= menuOption)
                    {
                        throw new OutOfMenuRangeException();
                    }
                    else
                    {
                        delegates[userOption - 1]();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format exception. You must get an option of the menu.");
                }
                catch (OutOfMenuRangeException)
                {
                    Console.WriteLine("Invalid option. Please, choose a number of the list.");
                }
            } while (!exit);
        }
        public static void showTipos()
        {
            for (int i = 0; i < Enum.GetValues(typeof(Tipo)).Length; i++)
            {
                Console.WriteLine(Enum.GetName(typeof(Tipo), i));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MenuGenerator menu = new MenuGenerator();
            menu.menu();
        }
    }
}
