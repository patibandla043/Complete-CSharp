using System;
class Static{
    public static int a=12;
    public static int b=34;
    static void display(){
        Console.WriteLine(a +" "+b);
    }
    static void Main(){
        display();
        Console.WriteLine(a+ " "+b);
    }
}