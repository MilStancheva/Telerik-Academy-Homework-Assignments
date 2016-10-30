using System;
using System.Linq;
using StrategyExampleRobotsApp.Contracts;

namespace StrategyExampleRobotsApp.Models
{
    public class Robot
    {
        private IBehaviour behaviour;
        private string name;

        public Robot(string name, IBehaviour behaviour)
        {
            this.Name = name;
            this.Behaviour = behaviour;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public IBehaviour Behaviour
        {
            get
            {
                return this.behaviour;
            }
            set
            {
                this.behaviour = value;
            }
        } 

        public void Move()
        {
            Console.WriteLine((this.name + ": Based on current position the behaviour object decide the next move:"));

            int command = this.behaviour.MoveCommand();
           
            Console.WriteLine("The result returned by behaviour object is sent to the movement mechanisms for the robot '" + this.name + "'");
        }
    }
}
