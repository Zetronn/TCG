using System;
using TCGMain;

namespace TCGMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards Bulbazaur = new Cards();
            Bulbazaur.Name = "Bulbazaur";
            Bulbazaur.Health = 100;

            Bulbazaur.showHP();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}