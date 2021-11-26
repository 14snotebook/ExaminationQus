using System;
using System.Linq;
using System.Collections.Generic;

namespace ExaminationQustions
{
    class op41_GenreicCollections
    {
        static void Main()
        {
            //Arraylist
            List<int> Speeds = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };
            Speeds.Add(130); //Adding
            //Display
            Console.WriteLine("Values inside the List is ");
            foreach(var Odometer in Speeds)
            Console.Write($"{Odometer}  ");
            //count 
            Console.WriteLine();
            Console.WriteLine($"No.of Elements in Speeds List  {Speeds.Count()}  ");
            Console.WriteLine();
            //insert
            Console.WriteLine("");
            Speeds.Insert(1, 15);
            foreach (var Odometer in Speeds)
                Console.Write($"{Odometer}  ");
            Console.WriteLine();
            //Remove
            Console.WriteLine("Removing 20 from List");
            Speeds.Remove(20);
            foreach (var Odometer in Speeds)
                Console.Write($"{Odometer}  "); Console.WriteLine();
            Console.WriteLine("======================================");
            //stack
            Stack<string> s = new Stack<string> { };
            //push
            s.Push("Hello");
            s.Push("Welcome");
            s.Push("Project");
            s.Push("Type");
            s.Push("WebApplication");
            //display
            foreach (var values in s)
                Console.Write($"{values} ");
            Console.WriteLine();
            //Peak
            Console.WriteLine($"First value of the stack is {s.Peek()}");
            //Pop
            Console.WriteLine($"Remove the value From Stack {s.Pop()}");
            //Count
            Console.WriteLine($"No.of Elements in the Stack is {s.Count()}");
            //Contains
            Console.WriteLine($"checking for the Hello {s.Contains("Hello")}");
            //Clear
            s.Clear();
            Console.WriteLine($"Clear the Stack ");
            Console.WriteLine("======================================");
            //Queue
            Queue<double> Prices = new Queue<double>();
            //Enqueue
            Prices.Enqueue(23.45);
            Prices.Enqueue(7867.09);
            Prices.Enqueue(15002.223);
            Prices.Enqueue(234.99);
            Prices.Enqueue(125430.2);
            //Display the elements
            foreach (var i in Prices)
                Console.Write($"{i}  ");
            Console.WriteLine();
            //Peak
            Console.WriteLine($"First value of the Queue is {Prices.Peek()}");
            //Dequeue
            Console.WriteLine($"Remove the value From Queue {Prices.Dequeue()}");
            //Count
            Console.WriteLine($"No.of Elements in the Queue is {Prices.Count()}");
            //Contains
            Console.WriteLine($"checking for the 7867.09 {Prices.Contains(7867.09)}");
            //Clear
            Prices.Clear();
            Console.WriteLine($"Clear the Queue ");
            //Dictionary
            Console.WriteLine("======================================");
            Dictionary<int, string> Books = new Dictionary<int, string>();
            Books.Add(1,"Physics");
            Books.Add(2,"Chimestry");
            Books.Add(3,"MATHS");
            Books.Add(4,"English");
            Books.Add(5, "Networks");
            //Display 
            foreach (int i in Books.Keys)
                Console.Write($"{i}  :  {Books[i]} \n");
         

        }
    }
}
