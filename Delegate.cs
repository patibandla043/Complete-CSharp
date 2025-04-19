using System;
class Delegate{
    public delegate void Addnum(int a,int b);
    public delegate void Subnum(int a,int b);
    public void Add(int a,int b){
        Console.WriteLine(a+b);
    }
    public void Sub(int a,int b){
        Console.WriteLine(a-b);
    }
    static void Main(){
        Delegate de=new Delegate();
        Addnum an=new Addnum(de.Add);
        Subnum sn=new Subnum(de.Sub);
        an(34,65);
        sn(54,23);
    }
}