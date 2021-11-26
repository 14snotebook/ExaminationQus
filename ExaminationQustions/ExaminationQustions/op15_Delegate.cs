using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    public delegate void Wishing(string s);
    public delegate int Maths(int i, int j);
    class op15_Delegate
    {
        public void Method(string s) => Console.WriteLine($"Hello {s} wishing message from Delegate Method");
        public int Maths1(int i, int x)
        {
            return i + x;
        }
        public int Math(int i, int x)
        {
            return i * x;
        }
        static void Main()
        {
            op15_Delegate obj = new();
            Wishing ws = new Wishing(obj.Method);
            ws("Pradeep");
            Maths mt = obj.Maths1;
            Console.WriteLine($" add {mt(23,2)}");
            mt += obj.Math;
            Console.WriteLine($" add {mt(12, 5)}");

        }
    }
}
