using StrategyExampleRobotsApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExampleRobotsApp.Models
{
    public class AgressiveBehaviour : IBehaviour
    {
        public int MoveCommand()
        {
            Console.WriteLine("\tAgressive Behaviour: if find another robot attack it");
            return 1;
        }
    }
}

