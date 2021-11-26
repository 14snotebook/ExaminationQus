using System;


namespace ExaminationQustions
{
    class implicittype
    {
        static void Main()
        {
            var i = 10;
            var f = 10.2f;
            var  s= "Pradeep";
            Console.WriteLine($"the value of i is {i} and it's type is{i.GetType()}");
            Console.WriteLine($"the value of  is {f} and it's type is {f.GetType()}");
            Console.WriteLine($"the value of  is {s} and it's type is {s.GetType()}");
        }
    }
}
