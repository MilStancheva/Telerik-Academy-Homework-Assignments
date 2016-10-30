using System;
using System.Linq;
using StrategyExampleRobotsApp.Contracts;

namespace StrategyExampleRobotsApp.Models
{
    public class DefensiveBehaviour : IBehaviour
    {
        public int MoveCommand()
        {
            Console.WriteLine("\tDefensive Behaviour: if find another robot run from it");
            return -1;
        }
    }
}
