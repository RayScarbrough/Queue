using System;
using System.Collections.Generic;

class Items
{
    static void Main()
    {
      
        Queue<string> myQueue = new Queue<string>();

      
        myQueue.Enqueue("Item1");
        myQueue.Enqueue("Item2");
        myQueue.Enqueue("Item3");
        myQueue.Enqueue("Item4");
        myQueue.Enqueue("Item5");
        Console.WriteLine("\n5 items added to the queue.");

        
        string searchItem = "Item3";
        if (myQueue.Contains(searchItem))
        {
            Console.WriteLine($"\nThe queue contains '{searchItem}'.");
        }
        else
        {
            Console.WriteLine($"\nThe queue does not contain '{searchItem}'.");
        }

        
        string removedItem = myQueue.Dequeue();
        Console.WriteLine($"" +
            $"\n'{removedItem}' has been removed from the queue.");

        
        int count = myQueue.Count;
        Console.WriteLine($"\nThere are {count} items in the queue.");

       
        Console.WriteLine("\nItems in the queue:");
        foreach (string item in myQueue)
        {
            Console.WriteLine(item);
        }
    }
}
