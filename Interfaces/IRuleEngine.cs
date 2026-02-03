using TCGMain.Models;

namespace TCGMain.Interfaces
{
    public interface IRuleEngine
    {
        RoundResult EvaluateRound(ElementType attacker, ElementType defender);
    }
}