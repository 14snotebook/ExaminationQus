using System;

namespace LOGICAL
{
    class q13           //Q13
    {
        static void Main()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(" * ");
                    else
                        Console.Write(j+" ");
                  
                }
                Console.WriteLine();
            }
        }
    }
}
