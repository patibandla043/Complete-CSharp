using System;
class Vari{
    int a=20,b=43;
    static int x=23,y=65;
    const int s=56;
    readonly int d=87;
    void display(){
        int p=67;
        Console.WriteLine(p);
    }
    static void Main(){
        Vari v=new Vari();
        Console.WriteLine(v.a+v.b);
        Console.WriteLine(y-x);
        Console.WriteLine(s);
        Console.WriteLine(v.d);
    }

}