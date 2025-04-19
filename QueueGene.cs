using System;
using System.Collections.Generic;
class QueyeGene{
    static void Display(Queue<int> s){
        foreach(int item in s){
            Console.WriteLine(item);
        }
    }
    static void Main(){
        Queue<int> queue =new Queue<int>();
        queue.Enqueue(12);
        queue.Enqueue(23);
        queue.Enqueue(34);
        Display(queue);
        Console.WriteLine("Top element : "+queue.Peek());
        Console.WriteLine("Popped Element : "+queue.Dequeue());
        Display(queue);
        Console.WriteLine("Is queue empty ? : "+(queue.Count==0));
        queue.Clear();
        Console.WriteLine("Is queue empty after clear? : "+(queue.Count==0));
    }
}