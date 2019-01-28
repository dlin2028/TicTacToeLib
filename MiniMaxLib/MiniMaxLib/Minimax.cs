using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreelessTicTacToe
{
    class Minimax
    {
        public int MiniMax(IGameState state, int currDepth, int maxDepth, int player)
        {
            if (state.GameOver || currDepth >= maxDepth)
            {
                return state.Score(player);
            }

            if (player != state.Player)
            {
                int maxMoveIndex = state.Moves().Select((x => MiniMax(x, currDepth + 1, maxDepth, player))).Max();
                return state.Moves()[maxMoveIndex].Score(player);
            }
            else
            {
                int minMoveIndex = state.Moves().Select((x => MiniMax(x, currDepth + 1, maxDepth, player))).Min();
                return state.Moves()[minMoveIndex].Score(player);
            }
        }
    }
}
