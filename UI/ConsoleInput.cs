using System;
using TCGMain.Interfaces;
using TCGMain.Models;

namespace TCGMain.UI
{
    public class ConsoleInput : IInputHandler
    {
        public ElementType GetMove(string playerName)
        {
            while (true)
            {
                Console.WriteLine($"\n{playerName}, choose attack (1.Fire, 2.Water, 3.Grass): ");
                var key = Console.ReadKey(true);

                if (key.KeyChar == '1') return ElementType.Fire;
                if (key.KeyChar == '2') return ElementType.Water;
                if (key.KeyChar == '3') return ElementType.Grass;

                Console.WriteLine("Invalid input.");
            }
        }
    }
}