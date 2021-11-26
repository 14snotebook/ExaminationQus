using System;

namespace ExaminationQustions
{
   sealed public  class op22_sealedClass
    {
        public void Method1() => Console.WriteLine("Hello from Sealed class");
    }
    class Accesssealed
    {
     static void Main()
        {
            op22_sealedClass obj = new();
            obj.Method1();
        }
    }

}
