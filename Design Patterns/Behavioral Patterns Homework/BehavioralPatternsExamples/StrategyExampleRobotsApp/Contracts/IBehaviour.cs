using System;
using System.Linq;

namespace StrategyExampleRobotsApp.Contracts
{
    public interface IBehaviour
    {
        int MoveCommand();
    }
}
