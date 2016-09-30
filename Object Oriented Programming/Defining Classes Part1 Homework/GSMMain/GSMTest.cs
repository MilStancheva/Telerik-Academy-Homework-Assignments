//Problem 7. GSM test
//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

namespace GSMMain
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        private GSM[] phonesCollection =
        {
            new GSM ("HTC", "One A9", 799.00, "Unknown", new Battery("Li-Ion 2150 mAh"), new Display(5.0, 16000000), new List<Call>()),
            new GSM ("THL", "2015А Black 4G", 339.00, "THL Phone Smart", new Battery ("Li-Ion 2700 mAh"), new Display(5.5, 16000000), new List<Call>()),
            new GSM ("Prestigio", "GRACE X3 PSP3455", 179.00, "Prestigio Enterprises", new Battery("Li-Ion 1650 mAh"), new Display(4.5), new List<Call>())

        };

        public void PrintGSMInfo()
        {
            for (int i = 0; i < phonesCollection.Length; i++)
            {
                Console.WriteLine("GSM {0} - {1}", i + 1, this.phonesCollection[i].ToString());
            }

            Console.WriteLine("IPhone Info: {0}", GSM.IPhone4S.ToString());
        }

    }
}
