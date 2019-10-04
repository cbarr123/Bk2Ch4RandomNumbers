using System;
using System.Collections.Generic;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
            if (numbers.Contains(i)){
                Console.WriteLine($"Numbers List contains {i}");
            } else
            {Console.WriteLine($"Numbers List does not contain {i}");};
            
            
            // Console.WriteLine(i);
            }
        }
    }
}
