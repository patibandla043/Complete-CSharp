using System;
class StaCon
{
    int a=20,b=43;
    static int x=23,y=65;
    const int s=56;
    readonly int d=87;
    void display(){
        int p=67;
        Console.WriteLine(p);
        p=34;
        Console.WriteLine(p);
    }
    void Show(){
        x=56;y=87;
        Console.WriteLine(x);
        Console.WriteLine(y);
        //d=89;
        Console.WriteLine(d);
        //s=545;
        Console.WriteLine(s);
    }

    static void Main(){
        StaCon v=new StaCon();
        Console.WriteLine(v.a+v.b);
        Console.WriteLine(y-x);
        Console.WriteLine(s);
        Console.WriteLine(v.d);
        v.display();
        v.Show();
    }

}