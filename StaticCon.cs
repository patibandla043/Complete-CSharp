// using static constrcutor we can't pass parameters , not use this keyword , copied constructor is not works and overloading is not support. 

using System;
class StaticCon{
    int age;
    string name;
    static StaticCon(int age,string name){
        this.age=age;
        this.name=name;
        Console.WriteLine("Helooooo");
        Console.WriteLine(age +" "+name);
    }
    public StaticCon(StaticCon sc){
        age=sc.age;
        name=sc.name;
    }
    public  display{
        get{
            Console.WriteLine(age+" "+name);
        }
    }
    static void Main(){
        new StaticCon(10,"priya"); 
    }
}