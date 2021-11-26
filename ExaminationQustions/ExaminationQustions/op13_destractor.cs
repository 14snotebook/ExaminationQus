using System;

namespace ExaminationQustions
{
    class op13_destractor
    {
        int i = 10;
        public op13_destractor()
        {
            Console.WriteLine($"the value of i is {i}");
        }
        ~op13_destractor()
        {
            Console.WriteLine("distractor is called");
            Console.WriteLine($"the value of i is {i}");
        }
        static void Main()
        {
            op13_destractor obj = new();
        }
    }
}
