using System;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    class op8_instancestaticmethods
    {
        public void Method() => Console.WriteLine("Hello from Instance Method..");
        public static void Method1() => Console.WriteLine("Hello from static Method..");
        static void Main()
        {
            op8_instancestaticmethods obj = new();
            obj.Method();
            op8_instancestaticmethods.Method1();
        }
    }
}
