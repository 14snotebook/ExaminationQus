using System;

namespace ExaminationQustions
{
    class op35_ExceptionHandle
    {
        static void Main()
        {  
            try
            {
                Console.Write("Enter 1st value : ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Enter 2st value : ");
                int j = int.Parse(Console.ReadLine());
                if (j % 2 != 0)
                    throw new externalexception();
                int d = i / j;
                Console.WriteLine($"result is {d}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you can't divide the value with 0");
            }
            //catch(FormatException)
            //{
            //    Console.WriteLine("Please enter only interger type..");
            //}
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This is the End of the program");
            }
        }
    }
    class externalexception : ApplicationException
    {
        public override string Message
        {
            get { return "Only Even Numbers are Accepted.."; }
        }

    }

}
