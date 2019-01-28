using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreelessTicTacToe
{
    interface IGame
    {
        IGameState State { get; }

    }
}
