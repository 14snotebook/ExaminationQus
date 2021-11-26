using System;

namespace ExaminationQustions
{
    class op17_Constractoroverloading
    {
        public op17_Constractoroverloading() => Console.WriteLine("Hello from Default Constractor");
        public op17_Constractoroverloading(string s) => Console.WriteLine($"Hii {s} Message from const.. overloading.....");
        static void Main()
        {
            op17_Constractoroverloading obj = new();
            op17_Constractoroverloading obj1 = new("Pradeep");
        }
    }
}
