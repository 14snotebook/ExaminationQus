using System;

namespace ExaminationQustions
{
    partial class op37_partialcalss
    {
        public void Method1() => Console.WriteLine("Hello From Method 1");
        public void Method2(string s) => Console.WriteLine($"Hello {s}");
    }
    partial class op37_partialcalss
    {
        public int add(int i,int j)
        {
            return i + j;
        }
    }
    class Testpart
    {
        static void Main()
        {
            op37_partialcalss obj = new();
            obj.Method1();
            obj.Method2("Pradeep");
            var i =obj.add(23,4);
            Console.WriteLine($"Addition of 23 , 4 numbers is {i} ");
        }
    }
}
