using System;

namespace ExaminationQustions
{
    class nullable
    {
        static void Main()
        {
            //5.Give example on nullable value types.
            int? i = null;
            float? f = null;
            string s = null;
            Console.WriteLine($"the int type accept null and it's value is {i}");
            Console.WriteLine($"the float type accept null and it's value is {f}");
            Console.WriteLine($"the string type accept null and it's value is {s}");
        }
    }
}
