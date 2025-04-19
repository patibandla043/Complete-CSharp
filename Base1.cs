using System;
public class sample1{
    public int a=90;
    public sample1(){
        Console.WriteLine("Hiii");
    }
    public void show(){
        Console.WriteLine("hello");
    }
}
class Base1:sample1{
    public Base1():base(){
        Console.WriteLine("this is child"); 
    }
    public void display(){
        base.show();
        Console.WriteLine(base.a);
        Console.WriteLine("byeeeee");
    }
    static void Main(){
        Base1 b1=new Base1();
        b1.display();        
    }
}