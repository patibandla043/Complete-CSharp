//collections generics with the Linq..
/*
using System;
using System.Collections.Generic;
using System.Linq;
class Lin1{
    static void Main(){
    List<string> n1=new List<string>{"Bindu","Nandu","water","fire};
    var s=from name in n1
    where name.StartsWith("w")
    select name;
    foreach (var item in s){
        Console.WriteLine(item);
    }
}
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
class Linqgen{
    static void Main(){
        List<string> n1=new List<string>{"Bindu","Nandu","Water","Fire"};
        var namesstartingWithA=from name in n1
        where name.StartsWith("F")
        select name;
        Console.WriteLine("Names starting with 'F':");
        foreach (var name in namesstartingWithA){
            Console.WriteLine(name);
        }
    }
}