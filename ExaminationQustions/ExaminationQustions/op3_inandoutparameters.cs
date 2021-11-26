using System;

namespace ExaminationQustions
{
    class op3_inandoutparameters
    {
        //3)Give one example on input and output parameters.
        public void inout(int i, int j, out int ad, out int mul)
        {
            ad = i + j;
            mul = i * j;
        }
        static void Main()
        {
            op3_inandoutparameters obj = new();
            int sum, mul;
            obj.inout(23, 5, out sum, out mul);
            Console.WriteLine($"Sum of the Two Number are {sum}");
            Console.WriteLine($"Multiplication of 23 and 5 is {mul}");
        }
    }
}
