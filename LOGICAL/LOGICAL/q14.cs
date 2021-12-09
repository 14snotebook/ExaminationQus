using System;
namespace LOGICAL
{
    class q14           //Q14
    {
        static void Main()
        {
            for(int i =1;i<6;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("* ");
                    else
                        Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
