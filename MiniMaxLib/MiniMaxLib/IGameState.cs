using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreelessTicTacToe
{
    interface IGameState
    {
        IGame Game { get; }
        int Player { get; }
        int NextPlayer { get; }
        bool GameOver { get; }
        IGameState[] Moves();
        int Score(int player);
    }
}
