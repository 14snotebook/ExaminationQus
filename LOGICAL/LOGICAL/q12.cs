using System;


namespace LOGICAL
{
    class q12           //Q12
    {
        static void Main()
        {
            for (int i = 1; i < 6 ; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write(j +" ");
                Console.WriteLine();
            }
        }
    }
}
