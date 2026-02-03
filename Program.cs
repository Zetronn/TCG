using System;
using TCGMain.Models;
using TCGMain.Interfaces;
using TCGMain.Services;
using TCGMain.UI;

namespace TCGMain
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputHandler input = new ConsoleInput();
            IDisplayHandler display = new ConsoleDisplay();
            IRuleEngine rules = new ElementalRuleEngine();

            display.ShowMessage("Enter Player 1 Name:");
            var p1 = new Player(Console.ReadLine());

            display.ShowMessage("Enter Player 2 Name:");
            var p2 = new Player(Console.ReadLine());

            GameMatch game = new GameMatch(p1, p2, rules, input, display);
            game.Play();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}