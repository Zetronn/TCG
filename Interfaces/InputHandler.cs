using TCGMain.Models;

namespace TCGMain.Interfaces
{
    public interface IInputHandler
    {
        ElementType GetMove(string playerName);
    }
}