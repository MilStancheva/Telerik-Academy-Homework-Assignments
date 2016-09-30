//Problem 5. Generic class
//Check all input parameters to avoid accessing elements at invalid positions

namespace GenericClass
{
    using Models;
    using System;

    public class Test
    {
        static void Main()
        {
            var list = new GenericList<int>(5);
            list.AddElement(5);
            list.AddElement(10);
            list.AddElement(20);
            list.AddElement(222);

            //Console.WriteLine(list[1]);

            //list.RemoveByIndex(1);
           // Console.WriteLine(list[1]);

            list.InsertAtGivenPosition(1, 123);
            list.InsertAtGivenPosition(5, 456);
            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
