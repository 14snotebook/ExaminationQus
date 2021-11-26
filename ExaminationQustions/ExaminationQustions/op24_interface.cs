using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    interface op24_interface
    {
        public void wish();
        public int Multiplication(int i, int j);
    }
    interface op24i_interface
    {
        public void wish();
        public int add(int i, int j);
    }
    class Interface1:op24_interface,op24i_interface
    {
        public void wish() => Console.WriteLine("wishing Message from Both the interfaces.");
        public int Multiplication(int i, int j)
        {
            return i * j;
        }
        public int add(int i, int j)
        {
            return i + j;
        }
        static void Main()
        {
            Interface1 obj = new();
            obj.wish();
            var i =obj.Multiplication(23,3);
            var j =obj.add(23,8);
            Console.WriteLine($" the Multiplication of 23,3  {i} ");
            Console.WriteLine($" the Addtion of 23,8 is  {j} ");
        }
    }
}
