using System;
using System.Collections;

namespace ExaminationQustions
{
    class op40_Hash
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            //Adding the values into HashTable.                 --Adding
            ht.Add("Series :" ,234);
            ht.Add("Vehicle Type :", "Two wheelers");
            ht.Add("Type :", "With gears");
            ht.Add("Top Speed :", 120);
            ht.Add("Price :", 100000.89);
            ht.Add("Having Licence :", true);
            //display the values using foreach loop
            foreach (object key in ht.Keys)
                Console.WriteLine(key  +" : "+ ht[key]);
            Console.WriteLine();
            //Removing element by using it's key value              -- Remove
            ht.Remove("Series :");
            //display the values using foreach loop
            foreach (object key in ht.Keys)
                Console.WriteLine(key + " : " + ht[key]);
            Console.WriteLine();
            //contains method                                       --Constains
            Console.WriteLine($" your searching Price (Existing -true/not-Existing -False)is {ht.Contains("Price :")}");
            //Count Method                                                  --Count
            Console.WriteLine($"your Hash Table contains {ht.Count}");
            //clear the all values from the hash table                      --Clear
            ht.Clear();

        }
    }
}
