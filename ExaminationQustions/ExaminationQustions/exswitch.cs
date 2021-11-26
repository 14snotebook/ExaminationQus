using System;

namespace ExaminationQustions
{
    class exswitch
    {
        static void Main()
        {
            //8.Give one example on switch.
            Console.Write("Enter your choice 1 2 3 :");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            { 
              case 1: 
                  Console.WriteLine("your selecting 1");
                    break;
              case 2: 
                  Console.WriteLine("your selecting 2");
                    break;
                case 3:
                    Console.WriteLine("your selecting 3");
                    break;
                default :
                    Console.WriteLine("Invalid Selection..");
                    break;
            
            }

        }
    }
}
