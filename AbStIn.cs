using System;
abstract class AbStIn{
    public abstract int age{get;}
    public static string name="Priya";
    public int marks=89;
    public abstract void Abst();
    public static void Stat(){
        Console.WriteLine("Static method");
    }
    public void Inst(){
        Console.WriteLine("Instance method");
    }
}
class Normal : AbStIn{
    int a=34;
    public override int age{get{ return a;}}
    public override void Abst(){
        Console.WriteLine("Abstract method");
    }
    static void Main(){
        Normal no=new Normal();
        Console.WriteLine(no.age);
        Console.WriteLine(no.marks);
        Console.WriteLine(name);
        no.Abst();
        Stat();
        no.Inst();
    }
}