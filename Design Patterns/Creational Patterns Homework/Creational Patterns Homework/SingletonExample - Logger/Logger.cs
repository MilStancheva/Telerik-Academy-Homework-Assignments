using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExampleLogger
{
    public class Logger : ILogger
    {
        private static Logger instance;

        private static object locker = new object();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }

                return instance;
            }
        }

        public void Log(string text)
        {
            var timeNow = DateTime.Now;
            Console.WriteLine($"{timeNow}: {text}");
        }
    }
}
