using TCGMain.Models;

namespace TCGMain.Interfaces
{
    public interface IDisplayHandler
    {
        void ShowMessage(string message);
        void ShowMatchStart(string p1, string p2);
        void ShowRoundResult(string p1Name, ElementType p1Move, string p2Name, ElementType p2Move, RoundResult result);
        void ShowWinner(string winnerName);
    }
}