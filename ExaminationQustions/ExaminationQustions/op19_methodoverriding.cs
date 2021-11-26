using System;

namespace ExaminationQustions
{
    class op19_methodoverriding
    {
        virtual public void Method() => Console.WriteLine("Hello From Paraent Method");
    }
    class childmethodoverriding : op19_methodoverriding
    {
        public override void Method() => Console.WriteLine("Hello from Child Class");
        static void Main()
        {
            childmethodoverriding obj = new();
            obj.Method();
        }


    }

}
