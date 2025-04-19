using System;
using System.Collections.Generic;
using System.Linq;
class Linanon{
    static void Main(){
        var s1=new List<Person>{
            new Person{Name="ram",Age=21},
            new Person{Name="Bindu",Age=21},
            new Person{Name="Nandu",Age=20},
            new Person{Name="Tarak",Age=19}, 
        };
        var result=from person in s1
        where person.Age<20
        select new{person.Name,person.Age};
        foreach(var item in result){
            Console.WriteLine(item);
        }
    }
    class Person{
        public string Name{get;set;}
        public int Age{get;set;}
    }
}