using System;
using System.Collections.Generic;

class Sortedlist
{
    static void Main()
    {
        SortedList<string, int> sortedList = new SortedList<string, int>();
        sortedList.Add("Apple", 1);
        sortedList.Add("Banana", 2);
        sortedList.Add("Cherry", 3);
        sortedList.Add("Date", 4);
        
        Display(sortedList);
        Console.WriteLine("Value for 'Banana': " + sortedList["Banana"]);
        sortedList.Remove("Cherry");
        Display(sortedList);
        Console.WriteLine("Contains 'Apple'? " + sortedList.ContainsKey("Apple"));
        Console.WriteLine("Contains 'Cherry'? " + sortedList.ContainsKey("Cherry"));
        
        Console.WriteLine("Iterating through SortedList:");
        foreach (var kvp in sortedList)
        {
            Console.WriteLine(kvp.Key +":"+ kvp.Value);
        }
        
        Console.WriteLine("Count of elements: " + sortedList.Count);
        sortedList.Clear();
        Console.WriteLine("Count after clear: " + sortedList.Count);
    }

    static void Display(SortedList<string, int> sortedList)
    {
        Console.WriteLine("SortedList contents:");
        foreach (var kvp in sortedList)
        {
            Console.WriteLine(kvp.Key +": "+ kvp.Value);
        }
        Console.WriteLine();
    }
}
