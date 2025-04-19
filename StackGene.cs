using System;
using System.Collections.Generic;
class StackGene{
    static void Display(Stack<int> s){
        foreach(int item in s){
            Console.WriteLine(item);
        }
    }
    static void Main(){
        Stack<int> stack =new Stack<int>();
        stack.Push(12);
        stack.Push(23);
        stack.Push(34);
        Display(stack);
        Console.WriteLine("Top element : "+stack.Peek());
        Console.WriteLine("Popped Element : "+stack.Pop());
        Display(stack);
        Console.WriteLine("Is stack empty ? : "+(stack.Count==0));
        stack.Clear();
        Console.WriteLine("Is stack empty after clear? : "+(stack.Count==0));
    }
}