using System;

namespace ExaminationQustions
{
    class op6_variablesstaticinstan
    {
        int i = 143;
        static string Name = "Nature";
        static void Main()
        {
            op6_variablesstaticinstan obj = new();
            Console.WriteLine($"Calling instance variabel  {obj.i}");
            Console.WriteLine($"Calling static variable {op6_variablesstaticinstan.Name}");
        }
    }
}
