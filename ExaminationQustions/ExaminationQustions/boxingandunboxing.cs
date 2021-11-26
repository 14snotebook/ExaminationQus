using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    class boxingandunboxing
    {
        //6.Give example on boxing and unboxing.
        static void Main()
        {
            int i = 100;
            object obj = i;
            Console.WriteLine($"Example on boxing {obj}");
            int j = (int)obj;
            Console.WriteLine($"Example on Un-Boxing {j}");
        }
    }
}
