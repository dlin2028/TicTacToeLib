using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniMaxLib;

namespace MiniMaxLib
{
    public abstract class GameTree
    {
        public IGameState Current;

        public void Move(bool isMax)
        {
            (IGameState state, double value) prime = (null, isMax ? double.MinValue : double.MaxValue);
            foreach (var child in Current.Children)
            {
                double result = Minimax(child, isMax);
                if((isMax && result > prime.value) || (!isMax && result < prime.value))
                {
                    prime = (child, result);
                }
                Current = prime.state;
            }
        }

        public static double Minimax(IGameState state, bool isMax)
        {
            if(state.IsTerminal)
            {
                return state.Value;
            }

            if(isMax)
            {
                double value = double.NegativeInfinity;
                foreach (var child in state.Children)
                {
                    value = Math.Max(value, Minimax(child, false));
                }
                return value;
            }
            else
            {
                double value = double.PositiveInfinity;
                foreach (var child in state.Children)
                {
                    value = Math.Min(value, Minimax(child, false));
                }
                return value;
            }
        }
    }
}
