using System;

namespace ExaminationQustions
{
    class op10_inheritence
    {
        //10)Give one example on inheritance.
        public void Method() => Console.WriteLine(" parent Method ");
        public void Method1() => Console.WriteLine("parent Method 1");
    }
    class child : op10_inheritence
    {
        public void Method2() => Console.WriteLine("Child Method 2");

        static void Main()
        {
            child obj = new();
            obj.Method();
            obj.Method1();
            obj.Method2();

        }
    }
}
