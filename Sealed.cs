using System;
class sealed Sample{
    public sealed int a=37;
    public sealed virtual void add(){
        a=679;
        Console.WriteLine(a);
        Console.WriteLine("Helooo");
    }
}
class Sealed : Sample{
    public override void add(){
        Console.WriteLine("Hii");
    }
    static void Main(){
        Sealed s=new Sealed();
        s.add();
    }
}