using System;

namespace ExaminationQustions
{
    class op16_Methodoverloading
    {
        //16)Give one Example on method overloading.
        public void wishing(string s) => Console.WriteLine($"Hello {s} How are you..");
        public void wishing(string SurName, string Name) => Console.WriteLine($"Hello {Name}.{SurName} How are you...");
        static void Main()
        {
            op16_Methodoverloading obj = new();
            obj.wishing("Pradeep");
            obj.wishing("Parikirala", "Pradeep");
        }
    }
}
