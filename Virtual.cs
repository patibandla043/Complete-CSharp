using System;
class Sample{
    public int a=29;
    public virtual void add(){
        a=876;
        Console.WriteLine(a);
        Console.WriteLine("Hii");
    }
}
class Virtual : Sample{
    public override void add(){
        Console.WriteLine("Add method");
    }
    static void Main(){
        Virtual v=new Virtual ();
        v.add();
    }
}