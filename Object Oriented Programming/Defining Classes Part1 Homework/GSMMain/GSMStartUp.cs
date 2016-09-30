namespace GSMMain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   

    public class GSMStartUp
    {
        static void Main()
        {
            //Problem 7. GSM test
            var test = new GSMTest();
            test.PrintGSMInfo();

            var newCall = new Call(new DateTime(2016, 06, 08, 18, 30, 20), "359 885 444 111", 120);
            Console.WriteLine(newCall.ToString());

            var testcall = new CallHistoryTest();
            testcall.TestHistory();
        }
    }
}
