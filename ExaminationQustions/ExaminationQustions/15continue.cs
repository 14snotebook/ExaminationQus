using System;
namespace ExaminationQustions
{
    class _15continue
    {
        static void Main()
        {
            //15.Give example on continue.
            Console.WriteLine("Example on Continue Statement");
            for (int i = 1; i < 5; i++)
            {
                if (i == 3)
                    continue;
               Console.Write(i+"  ");
            }
        }
    }
}
