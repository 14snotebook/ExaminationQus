using System;

namespace ExaminationQustions
{
    //18)Give one example on inheritance based method overloading.
    class op18_inheritmethodoverloading
    {
       public void Method1(string s) => Console.WriteLine($"Hello {s} wishing message from Parent Method ");
    }
    class methodoverridingchild : op18_inheritmethodoverloading
    {
        public void Method1(string s, string s1) => Console.WriteLine($"Hello {s} . {s1} wishing Message from Child Class");
       static void Main()
        {
            methodoverridingchild obj = new();
            obj.Method1("Pradeep","Parikirala");
        }


    }

}
