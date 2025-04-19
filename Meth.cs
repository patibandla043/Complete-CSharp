using System;
class Meth
{
    int a=20,b=43;
    static int x=23,y=65;
    
    void display(){
        
        Console.WriteLine(a+b);
        
        Console.WriteLine(y-x);
    }
    static void Show(){
        //Console.WriteLine(a+b);
        
        Console.WriteLine(y-x);
    }

    static void Main(){
        Meth v=new Meth();
        
        v.display();
        Show();
    }

}