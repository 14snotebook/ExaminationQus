using System;

namespace ExaminationQustions
{
    class op5_defaultandparmeterizedcons
    {
        public op5_defaultandparmeterizedcons() => Console.WriteLine("Hello from Default Constractor..");
        public op5_defaultandparmeterizedcons(string s) => Console.WriteLine($"Hello {s} wishes from parametrized Constrtuctor.");
        static void Main()
        {
            op5_defaultandparmeterizedcons obj1 = new();
            op5_defaultandparmeterizedcons obj = new op5_defaultandparmeterizedcons("Pradeep");
        }
    }
}
