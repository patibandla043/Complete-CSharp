using System;
using System.Collections.Generic;
class Linkedlist{
    static void Main(){
        LinkedList<int> l1=new LinkedList<int>();
        l1.AddLast(20);
        l1.AddLast(76);
        l1.AddLast(12);
        l1.AddFirst(24);
        l1.Remove(76);
        Console.WriteLine(Search(l1,76));
        foreach(int i in l1){
            Console.Write(i+" ");
        }
    }
        static bool Search(LinkedList<int> list,int value){
            return list.Contains(value);
        }
    
}