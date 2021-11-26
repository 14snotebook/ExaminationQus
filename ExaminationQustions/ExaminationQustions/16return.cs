using System;

namespace ExaminationQustions
{
    class _16return
    {
        //16.Give example on return.
        public int Add(int i , int j)
        {
            return i + j;
        }
        static void Main()
        {
            _16return obj = new();
            var result = obj.Add(12, 78);
            Console.WriteLine($"the sum of the two numbers is {result}");
        }
    }
}
