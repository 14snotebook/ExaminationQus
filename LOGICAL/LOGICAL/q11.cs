using System;

namespace LOGICAL
{
    class q11       //Q11
    {
        static void Main()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 5;j>= i;j--)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }
    }
}
