using System;
using System.Collections.Generic;
class Linkedlist{
    static void Main(){
        LinkedList<int> l1=new LinkedList<int>();
        l1.AddLast(20);
        l1.AddLast(76);
        l1.AddLast(12);
        l1.AddFirst(24);
        
        IEnumerator<int> ie=l1.GetEnumerator();
        while(ie.MoveNext()){
            Console.Write(ie.Current+" ");
        }
        Console.WriteLine();
        foreach(int i in l1){
            Console.Write(i+" ");
        }
    }
}