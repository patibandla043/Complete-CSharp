using System;
abstract class Marks{
    public abstract int marks{get;}
}
class Sys : Marks{
    private int _mark=95;
    public override int marks {get { return _mark;}}
    
    public double Percen(){
        return (double)marks/100*100;
    }
    static void Main(){
        Sys s=new Sys();
        Console.WriteLine(s.Percen());
    }
}