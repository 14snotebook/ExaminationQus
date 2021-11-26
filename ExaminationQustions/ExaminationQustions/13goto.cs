using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationQustions
{
    class _13goto
    {
        static void Main()
        {
            //13.Give example on goto.
            Console.WriteLine("Example on Goto using swith case..");
            Console.Write("Enter Your Choice 1 2 3 : ");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
              case 1:
                  Console.WriteLine("your selecting 1");
                    goto xxx;
                    break;
              case 2:
                  Console.WriteLine("your selecting 2");
                xxx:
                    Console.WriteLine("am exiguting because of the goto statement..");
                    break;
                case 3:
                    Console.WriteLine("your selecting 3");
                    break;
                default :
                    Console.WriteLine("Invalid selection..");
                    break;
            
            }


                //goto xxx;
                //Console.WriteLine("goto is transfor the control");
                //xxx:
                //Console.WriteLine("goto exigute the control..");
                
        


            
        }
    }
}
