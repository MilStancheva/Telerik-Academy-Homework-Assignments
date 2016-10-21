using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExampleLogger
{
    public class StartUp
    {
        public static void Main()
        {
            string text = "Singleton example implemented.";
            Logger.Instance.Log(text);
        }
    }
}
