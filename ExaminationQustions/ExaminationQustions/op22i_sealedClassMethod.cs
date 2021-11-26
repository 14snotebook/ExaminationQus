using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    class op22i_sealedClassMethod
    {
        virtual public void Method() => Console.WriteLine("this is implimented for sealed method..");
    }
    class childsealed : op22i_sealedClassMethod
    {
        public sealed override void Method()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello from Sealed method am not allowed to change the content.which is prasent inside the in this method..");
        }
        static void Main()
        {
            childsealed sd = new();
            sd.Method();
        }

    }
    class forsealed : childsealed
    {
        // public override void Method() => Console.WriteLine();  this is not allowed to change.
    
    }

}
