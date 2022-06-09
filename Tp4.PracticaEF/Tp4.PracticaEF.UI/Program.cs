using System;

namespace Tp4.PracticaEF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UI.ShowMainMenu();
            var input = Console.ReadLine().ToString().ToUpper();
            while (input != "N")
            {

                switch (input)
                {
                    case "1":
                        UI.ShowList(input);
                        break;
                    case "2":
                       UI.ShowList(input);
                        break;
                    case "3":
                        InputHandling.ShippersAddMenu();
                        break;
                    case "4":
                        InputHandling.ShippersDeleteMenu();
                        break;
                    case "5":
                        InputHandling.ShippersUpdateMenu();
                        break;
                    case "X":
                        Console.Clear();
                        Console.WriteLine("Adios");

                        return;
                    default:
                        Console.WriteLine("Por favor ingrese una opcion valida");
                        break;

                }

                Console.ReadLine();
                Console.Clear();
                UI.ShowMainMenu();
                input = Console.ReadLine().ToString().ToUpper();
            }

            Console.ReadLine();
        }
    }
}
