using System;
using System.Collections.Generic;

namespace HappyCoding03262021_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame;
            var itemList = new Dictionary<int, Element>();
            itemList.Add(0, new Schere());
            itemList.Add(1, new Stein());
            itemList.Add(2, new Papier());

            do
            {
                continueGame = false;

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Willkommen zu 'Schere', 'Stein', 'Papier'!");
                Console.WriteLine("Bitte geben Sie ein Element ein.");

                var input = Console.ReadLine();
                Random computerRandom = new Random();
                var computerOption = computerRandom.Next(0, 2);

                switch (input.ToLower())
                {
                    case "schere":
                        Console.WriteLine(itemList[computerOption].ValidateResult("schere"));
                        break;
                    case "stein":
                        Console.WriteLine(itemList[computerOption].ValidateResult("stein"));
                        break;
                    case "papier":
                        Console.WriteLine(itemList[computerOption].ValidateResult("papier"));
                        break;
                    default:
                        Console.WriteLine($"Element {input} ist nicht bekannt.");
                        break;
                }

                Console.WriteLine("Wollen Sie noch eine Runde spielen? Geben Sie bitte 'ja' ein oder drücken sie enter zum beenden der anwendung.");
                var continueInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(continueInput) && continueInput.ToLower() == "ja")
                {
                    continueGame = true;
                }

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
            } while (continueGame);
        }
    }
}
