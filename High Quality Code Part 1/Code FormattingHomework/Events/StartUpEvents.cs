using System;

namespace Events
{
    public class StartUpEvents
    {
        public static void Main(string[] args)
        {
            while (CommandExecutor.ExecuteNextCommand())
            {
            }

            Console.WriteLine(Messages.Output);
        }
    }
}
