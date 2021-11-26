using System;
using System.Collections;

namespace ExaminationQustions
{
    class op38_stack
    {
        static void Main()
        {
            Stack s = new Stack();
            //insert the valuse into Stack      --PUSH
            s.Push(12);
            s.Push(125);
            s.Push(85);
            s.Push(7);
            s.Push(2);
            //display the values in the stack
            foreach (var i in s)
                Console.Write($"{i} ");
            Console.WriteLine();
            //Remove the values from Stack          --POP
            Console.WriteLine($"Removing value is {s.Pop()}");
            //After Remove the element
            foreach (var i in s)
                Console.Write($"{i} ");
            Console.WriteLine();
            //See the top element           --PEAK
            Console.WriteLine($"top element of the Stack is {s.Peek()}");
            //the size of Stack is          --COUNT
            var size=s.Count;
            Console.WriteLine($"the size of the Stack is {size}");
            //insert the elements into Stack        --push
            s.Push("Hello");
            foreach (var i in s)
                Console.Write($"{i} ");
            Console.WriteLine();
            //clear the elements            --CLEAR
            s.Clear();
            Console.WriteLine("After Clear the Stack ");
            foreach (var i in s)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
