using System;

namespace ExaminationQustions
{
    class op2_parameterMethod
    {
        //2)Give one example on pass parameters to method.
        public void Method(string s) => Console.WriteLine($"Hello {s} How are you...??");
        static void Main()
        {
            op2_parameterMethod obj = new();
            obj.Method("Pradeep");
        }
    }
}
