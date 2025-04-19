using System;
using System.Collections;

class HashTable
{
    static void Main()
    {

        Hashtable hashtable = new Hashtable();
        hashtable.Add("Apple", 1);
        hashtable.Add("Banana", 2);
        hashtable.Add("Cherry", 3);
        hashtable.Add("Date", 4);

        Display(hashtable); 

        Console.WriteLine("Value for 'Banana': " + hashtable["Banana"]); 
        hashtable.Remove("Cherry");
        Display(hashtable); 
        Console.WriteLine("Contains 'Apple'? " + hashtable.ContainsKey("Apple")); 
        Console.WriteLine("Contains 'Cherry'? " + hashtable.ContainsKey("Cherry")); 

        Console.WriteLine("Iterating through Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key +":"+ entry.Value);
        }
        Console.WriteLine("Count of elements: " + hashtable.Count); 
        Console.WriteLine("Count after clear: " + hashtable.Count); 
    }
    static void Display(Hashtable hashtable)
    {
        Console.WriteLine("Hashtable contents:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key +":"+ entry.Value);
        }
        Console.WriteLine();
    }
}