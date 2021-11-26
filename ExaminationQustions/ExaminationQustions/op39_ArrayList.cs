using System;
using System.Collections;
namespace ExaminationQustions
{
    class op39_ArrayList
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine($"initial memory capacity of Arraylist is {al.Capacity}");            //Capacity
            //Adding the vaule to the Arraylist         --Add
            al.Add(23);
            al.Add(9.8f);
            al.Add(23.00);
            al.Add("Gravity");
            al.Add(true);
            //Display the value using foreach loop
            foreach (var i in al)
                Console.Write($"{i}  ");
            Console.WriteLine();
            //capacity property                     
            Console.WriteLine($"Memory capacity of the ArrayList is {al.Capacity}");
            //count of the element inside the Arraylist                         --count
            Console.WriteLine($"No.of element in the ArrayList is {al.Count}");
            //inserted at 2nd Index                             --Insert
            al.Insert(2,"am Inserted");
            foreach (var i in al)
                Console.Write($"{i}  ");
            Console.WriteLine();
            //Checking the element using containes Method               --Contains
            Console.WriteLine($" we are searching for 23 if it's prasent the return TRUE else FALSE {al.Contains(23)}");
            //Case 2:
            Console.WriteLine($" we are searching for 23 if it's prasent the return TRUE else FALSE {al.Contains("Apple")}");
            //Finding the element Index                         --IndexOf
            Console.WriteLine($"the index of Gravity is {al.IndexOf("Gravity")}");
            //Remove the element using Remove Method            --Remove
            Console.WriteLine("After Removing the 23 from the Arraylist the values inside the Arraylist.");
            al.Remove(23);
            foreach (var i in al)
                Console.Write($"{i}  ");
            Console.WriteLine();
            Console.WriteLine("Removing the element at 2 nd index");
            //Remove using index value                                      --RemoveAt();
            al.RemoveAt(2);
            foreach (var i in al)
                Console.Write($"{i}  ");
            Console.WriteLine();
            //sort the Arraylist                                        --sort
            ArrayList al1 = new ArrayList() {12,8,5,78,9,32,5 };
            Console.WriteLine("sorting of the element in ascending order");
            al1.Sort();
            foreach (var i in al1)
                Console.Write($"{i}  ");
            Console.WriteLine();
            Console.WriteLine("sorting of the element in descending order");
            al1.Reverse();                                          //Reverse
            foreach (var i in al1)
                Console.Write($"{i}  ");
            Console.WriteLine();
            //clear the elements        --Clear
            al.Clear();
            al1.Clear();
        }
    }
}
