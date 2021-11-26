using System;

namespace ExaminationQustions
{
    class exdowhileloop
    {
        static void Main()
        {
            Console.WriteLine("Printing the values from 1 to 5 using do-while loop");
            int i = 1;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i<=5);
        }
    }
}
