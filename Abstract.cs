using System;
abstract class Abstract{
    public abstract void display();
}
class Priya: Abstract {
    public override void display(){
        Console.WriteLine("Helloo");
    }
    public void show(){
        Console.WriteLine("haiiiiiiiiiiii");
    }
    static void Main(){
        Priya p=new Priya();
        p.display();
        p.show();
    }
}