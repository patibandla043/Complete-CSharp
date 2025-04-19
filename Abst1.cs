using System;
abstract class Abst1{
    public abstract void Imp();
    public void display(){
        Console.WriteLine("Abstract class method");
    }
    public static void Show(){
        Console.WriteLine("Abstract class Static method");
    }
}
class Priya : Abst1{
    public override void Imp(){
        Console.WriteLine("Abstract method");
    }
}
class Bindu : Abst1{
    public override void Imp(){
        Console.WriteLine("Override Method");
    }

    static void Main(){
        Priya p=new Priya();
        p.Imp();
        Show();
        p.display();
        Bindu b=new Bindu();
        b.Imp();
        Abst1 ab=new Priya();  // We can create reference to abstract class
        ab.Imp();
    }
}