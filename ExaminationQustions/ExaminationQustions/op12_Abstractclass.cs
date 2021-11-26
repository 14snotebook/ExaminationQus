using System;

namespace ExaminationQustions
{
   abstract class op12_Abstractclass
    {
        //12)Give one example on abstract class.
        public void Method() => Console.WriteLine("Hello this is Normal Method in Abstract class");
        abstract public void Method1();
        abstract public void Method2(string s);
    }
    class childforAbastract : op12_Abstractclass
    {
        public override void Method1()
        {
            Console.WriteLine("Abstract Method definde in child class");
        }
        public override void Method2(string s)
        {
            Console.WriteLine($"Hello {s} whishing Message from Abstract parametarized Method");
        }
        static void Main()
        {
            childforAbastract obj = new();
            obj.Method();
            obj.Method1();
            obj.Method2("Pradeep");
        }

    }

}
