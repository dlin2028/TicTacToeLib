using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxLib
{
    public interface IGameState
    {
        double Value { get; set; }
        bool IsTerminal { get; set; }
        IGameState[] Children { get;}
    }
}
