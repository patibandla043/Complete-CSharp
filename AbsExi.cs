using System;
class AbsExi{
    public abstract void Abs();
    public static void Sta(){
        static int a=23;
        static int b=45;
        Console.WriteLine(a+" "+b);

    }
}
static class Static : AbsExi{
    public override void Abs(){
        Console.WriteLine("Abstract method");
    }
    static void Main(){
        Static as=new Static();
        as.Abs();
        as.Sta();
    }
}