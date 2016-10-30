using System;
using System.Linq;
using StrategyExampleRobotsApp.Contracts;

namespace StrategyExampleRobotsApp.Models
{
    public class NormalBehaviour : IBehaviour
    {
        public int MoveCommand()
        {
            Console.WriteLine("\tNormal Behaviour: if find another robot ignore it");
            return 0;
        }
    }
}
