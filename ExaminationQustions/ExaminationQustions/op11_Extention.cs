using System;

namespace ExaminationQustions
{
    public class op11_Extention
    {
        public void Method() => Console.WriteLine("Example on Extension Method..");
        static void Main()
        {
            op11_Extention obj = new();
            obj.Method();
            obj.Method1();
            obj.Method2("Pradeep");
        }
    }
    public static class forop11_Extention
    {
        public static void Method1(this op11_Extention obj) => Console.WriteLine("Am extention Method definded in  forop11_Extension");
        public static void Method2(this op11_Extention obj, string s) => Console.WriteLine($"Hello {s} wishing from Extension Method..");
    }

}
