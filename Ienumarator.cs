using System;
using System.Collections.Generic;
class Ienumarator{
    static void Main(){
        List<string> s1=new List<string>{"Red","Yellow","Blue"};
        IEnumerator<string> e1=s1.GetEnumerator();

        while(e1.MoveNext()){
            Console.WriteLine(e1.Current);
        }
    }
}