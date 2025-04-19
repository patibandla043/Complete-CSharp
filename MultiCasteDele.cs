using System;
class MultiCasteDele{
    public delegate void Addnum(int a,int b);
    
    public void Add(int a,int b){
        Console.WriteLine(a+b);
    }
    public void Sub(int a,int b){
        Console.WriteLine(a-b);
    }
    static void Main(){
        MultiCasteDele de=new MultiCasteDele();
        Addnum an=new Addnum(de.Add);
        an=an+de.Sub;
        an.Invoke(34,21);
        an.Invoke(54,23);
    }
}