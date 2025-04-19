using System;
abstract class MultiAbs{
    public abstract void display();
    public abstract void show();
}
abstract class Abst{
    public abstract void print();
    public static void imp(){
        Console.WriteLine("Static method");
    }
}
class OneAbs : MultiAbs{
    public override void display(){
        Console.WriteLine("Display method");
    }
    public override void show(){
        Console.WriteLine("Show method");
    }
}
class TwoAbs :Abst {
    public override void print(){
        Console.WriteLine("Print method");
    }
    static void Main(){
        OneAbs oa=new OneAbs();
        oa.display();
        oa.show();
        TwoAbs ts=new TwoAbs();
        ts.print();
        imp();
    }
}