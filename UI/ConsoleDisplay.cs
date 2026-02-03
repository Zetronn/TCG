using System;
using TCGMain.Interfaces;
using TCGMain.Models;

namespace TCGMain.UI
{
    public class ConsoleDisplay : IDisplayHandler
    {
        public void ShowMessage(string message) => Console.WriteLine(message);

        public void ShowMatchStart(string p1, string p2)
        {
            Console.Clear();
            Console.WriteLine($"=== MATCH START: {p1} vs {p2} ===");
            Console.WriteLine("First to 3 points wins!");
            Console.WriteLine("-----------------------------");
        }

        public void ShowRoundResult(string p1Name, ElementType p1Move, string p2Name, ElementType p2Move, RoundResult result)
        {
            Console.Clear();
            Console.WriteLine($"P1 ({p1Name}) chose: {p1Move}");
            Console.WriteLine($"P2 ({p2Name}) chose: {p2Move}");
            Console.WriteLine("-----------------------------");

            if (result == RoundResult.Win) Console.WriteLine($">>> {p1Name} wins the round!");
            else if (result == RoundResult.Loss) Console.WriteLine($">>> {p2Name} wins the round!");
            else Console.WriteLine(">>> It's a Draw!");

            Console.WriteLine("\nPress any key for next round...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ShowWinner(string winnerName)
        {
            Console.WriteLine($"\n**********************************");
            Console.WriteLine($"   WINNER: {winnerName}");
            Console.WriteLine($"**********************************");
        }
    }
}