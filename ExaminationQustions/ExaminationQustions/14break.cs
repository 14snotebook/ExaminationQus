using System;

namespace ExaminationQustions
{
    class _14break
    {
        static void Main()
        {
            //14.Give example on break.
            Console.WriteLine("Example on Break Statement..");
            for (int i = 1; i < 5; i++)
            {
                Console.Write(i + "  ");
                if (i == 3)
                    break;
            }
        }
    }
}
