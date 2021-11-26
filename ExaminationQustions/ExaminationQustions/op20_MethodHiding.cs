using System;

namespace ExaminationQustions
{
    class op20_MethodHiding
    {
        public void Method() => Console.WriteLine("hello from parent Method");
    }
    class methodHiding:op20_MethodHiding
    {
        new public void Method() => Console.WriteLine("Hello from Child method (this method hide the parent Method)");
        static void Main()
        {
            methodHiding obj = new();
            obj.Method();
        }
    }
}
