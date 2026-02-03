using TCGMain.Interfaces;
using TCGMain.Models;

namespace TCGMain.Services
{
    public class GameMatch
    {
        private readonly Player _p1;
        private readonly Player _p2;
        private readonly IRuleEngine _rules;
        private readonly IInputHandler _input;
        private readonly IDisplayHandler _display;
        private readonly int _winningScore;

        public GameMatch(Player p1, Player p2, IRuleEngine rules, IInputHandler input, IDisplayHandler display, int winningScore = 3)
        {
            _p1 = p1;
            _p2 = p2;
            _rules = rules;
            _input = input;
            _display = display;
            _winningScore = winningScore;
        }

        public void Play()
        {
            _display.ShowMatchStart(_p1.Name, _p2.Name);

            while (_p1.Score < _winningScore && _p2.Score < _winningScore)
            {
                ElementType p1Move = _input.GetMove(_p1.Name);
                ElementType p2Move = _input.GetMove(_p2.Name);

                RoundResult result = _rules.EvaluateRound(p1Move, p2Move);

                if (result == RoundResult.Win) _p1.AddPoint();
                else if (result == RoundResult.Loss) _p2.AddPoint();

                _display.ShowRoundResult(_p1.Name, p1Move, _p2.Name, p2Move, result);
            }

            string winner = _p1.Score >= _winningScore ? _p1.Name : _p2.Name;
            _display.ShowWinner(winner);
        }
    }
}