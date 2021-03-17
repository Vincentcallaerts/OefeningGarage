using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            List<Merk> merken = new List<Merk>();
            Merk tesla = new Merk("Tesla", "Tesla`s Dream. Your Reality");
            Merk volvo = new Merk("Volvo", "Volvo. For life");
            Merk bmw = new Merk("Bmw", "Freude an Fahren");
            merken.Add(tesla);
            merken.Add(bmw);
            merken.Add(volvo);

            Auto auto1 = new Auto(bmw, 2000);
            Auto auto2 = new Auto(tesla, 5000);
            Auto auto3 = new Auto(volvo, 3000);
            Auto[] autos = { auto1, auto2, auto3 };

            Rijkezakenman elon = new Rijkezakenman();

            elon.Wagenparken.Add(new Wagenpark());
            elon.Wagenparken.Add(new Wagenpark());
            elon.Wagenparken[0].GraragesInParken.Add(new Garage());
            elon.Wagenparken[1].GraragesInParken.Add(new Garage());
            elon.Wagenparken[0].GraragesInParken.Add(new Garage());
            elon.Wagenparken[0].GraragesInParken[0].GarageOpslag.Add(auto1);
            elon.Wagenparken[1].GraragesInParken[0].GarageOpslag.Add(auto1);
            elon.Wagenparken[0].GraragesInParken[0].GarageOpslag.Add(auto1);

            while (running)
            {
                
                
                switch (SelectMenu("Welkom Bij het Rijkezakenman Wagenparken Nv Beheersysteem", "Auto Kopen", "Auto Verkopen", "Overzicht Wagens"))
                {
                    case 0:
                        switch (SelectMenu("", "Auto Kopen", "Auto Verkopen", "Overzicht Wagens"))
                        {
                            default:  
                                break;
                        }
                        break;
                    case 1:
                        break;
                    case 2: 
                        elon.ToonAlles();
                                               
                        Console.WriteLine("Druk enter voor verder te gaan");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }

        }
        static int SelectMenu(Auto[] autos)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                for (int i = 0; i < autos.Length; i++)
                {

                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.WriteLine($"{autos[i].Beschrijf()}");

                    Console.ResetColor();

                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), autos.Length);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection - 1;
        }

        static int SelectMenu(string message, params string[] menu)
            {
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;
                Console.Clear();

                int selection = 1;
                bool selected = false;
                ConsoleColor selectionForeground = Console.BackgroundColor;
                ConsoleColor selectionBackground = Console.ForegroundColor;

                while (!selected)
                {

                    Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
                    Console.WriteLine(message);
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = 0; i < menu.Length; i++)
                    {

                        if (selection == i + 1)
                        {
                            Console.ForegroundColor = selectionForeground;
                            Console.BackgroundColor = selectionBackground;
                        }
                        Console.SetCursorPosition((Console.WindowWidth - menu[i].Length) / 2, Console.CursorTop);
                        
                        Console.WriteLine($"{menu[i]}");

                        Console.ResetColor();

                    }

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.UpArrow:
                            selection--;
                            break;
                        case ConsoleKey.DownArrow:
                            selection++;
                            break;
                        case ConsoleKey.Enter:
                            selected = true;
                            break;
                    }

                    selection = Math.Min(Math.Max(selection, 1), menu.Length);
                    Console.SetCursorPosition(0, 0);
                }

                Console.Clear();
                Console.CursorVisible = true;

                return selection - 1;
            }
        }
}
