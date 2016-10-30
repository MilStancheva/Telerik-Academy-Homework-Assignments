using StrategyExampleRobotsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExampleRobotsApp
{
    public class StartUp
    {
        public static void Main()
        {
            Robot bigRobot = new Robot("Big Robot", new AgressiveBehaviour());
            Robot george = new Robot("George v.2.1", new DefensiveBehaviour());
            Robot secondRobot = new Robot("R2", new NormalBehaviour());

            bigRobot.Move();
            george.Move();
            secondRobot.Move();

            Console.WriteLine($"New behaviours: {bigRobot.Name} gets really scared; {george.Name} v.2.1' becomes really mad because it's always attacked by other robots and {secondRobot.Name} keeps its calm");

            bigRobot.Behaviour = new DefensiveBehaviour();
            george.Behaviour = new AgressiveBehaviour();

            bigRobot.Move();
            george.Move();
            secondRobot.Move();
        }
    }
}
