//Problem 12. Call history test
//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

namespace GSMMain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CallHistoryTest
    {
        private GSM myGSM = new GSM("LG", "G4");
        List<Call> myGSMCallHistory = new List<Call>();
        private const decimal pricePerMinute = 0.37m;

        public void TestHistory()
        {
            myGSM.CallHistory = myGSMCallHistory;
            Call firstCall = new Call(new DateTime(2016, 06, 08, 18, 15, 15), "359 885 665 009", 120);
            Call secondCall = new Call(new DateTime(2016, 06, 07, 10, 54, 45), "359 883 672 111", 190);
            Call thirdCall = new Call(new DateTime(2016, 06, 06, 15, 30, 30), "359 889 998 999", 60);

            myGSM.AddCall(firstCall);
            myGSM.AddCall(secondCall);
            myGSM.AddCall(thirdCall);

            Console.WriteLine(myGSM.PrintCallHistory()); 
            Console.WriteLine("Total price: {0:0.00}", myGSM.CaculateTotalCallPrice(pricePerMinute));

            Call longestCall = myGSM.CallHistory.OrderByDescending(x => x.Duration).First();

            myGSM.DeleteCall(longestCall);

            Console.WriteLine("Final price: {0:0.00}", myGSM.CaculateTotalCallPrice(pricePerMinute));

            myGSM.ClearHistory();

            Console.WriteLine(myGSM.PrintCallHistory());
        }
    }
}
