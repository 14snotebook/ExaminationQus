using System;

namespace LOGICAL
{
    class q10       //Q10
    {
        static void Main()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <=i; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }
    }
}
