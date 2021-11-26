using System;

namespace ExaminationQustions
{
    class op9_staticandinstanceconstr
    {
        public op9_staticandinstanceconstr() => Console.WriteLine("Hello from instance Constractor");
        static op9_staticandinstanceconstr() => Console.WriteLine("Hello from static constractor");
       static void Main()
        {
            op9_staticandinstanceconstr obj = new();
        }
    }
}
