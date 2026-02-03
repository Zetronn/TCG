using System.Collections.Generic;
using TCGMain.Interfaces;
using TCGMain.Models;

namespace TCGMain.Services
{
    public class ElementalRuleEngine : IRuleEngine
    {
        private readonly Dictionary<ElementType, ElementType> _winsAgainst
            = new Dictionary<ElementType, ElementType>
        {
            { ElementType.Fire, ElementType.Grass },
            { ElementType.Grass, ElementType.Water },
            { ElementType.Water, ElementType.Fire }
        };

        public RoundResult EvaluateRound(ElementType p1Move, ElementType p2Move)
        {
            if (p1Move == p2Move) return RoundResult.Draw;

            if (_winsAgainst.ContainsKey(p1Move) && _winsAgainst[p1Move] == p2Move)
            {
                return RoundResult.Win;
            }

            return RoundResult.Loss;
        }
    }
}