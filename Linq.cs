using System;
using System.Collections.Generic;
using System.Linq;
class Linq{
    static void Main(){
        List<string> s1=new List<string>{"Red","Yellow","Blue","yerri"};
        var s2=s1.Where(n=>n.StartsWith("Y"));

        foreach(var x in s2){
            Console.WriteLine(x);
        }
    }
}