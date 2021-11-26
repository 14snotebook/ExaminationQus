using System;

namespace ExaminationQustions
{
    class op7_constreadonly
    {
        const float pi=3.14f;// declare and initilize  at a time
        public readonly float Gravity; //declare 
        public op7_constreadonly()
        {
            Gravity = 9.8f; //initilize 
        }
        static void Main()
        {
            op7_constreadonly obj = new();
            Console.WriteLine($"the value of the Readonly  is {obj.Gravity}");
            Console.WriteLine($"the value of the const  is {pi}");
        }
         
    }
}
