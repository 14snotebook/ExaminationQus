using System;

namespace ExaminationQustions
{
    class exforeachloop
    {
        static void Main()
        {
            //12.Give example on foreach loop.
            Console.WriteLine("Printing the Array values using Foreach Loop");
            int[] arr = { 2, 23, 56, 22, 98, 1023, 56 };
            foreach (var i in arr)
                Console.Write(i+"  ");
        }
    }
}
