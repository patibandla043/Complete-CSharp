using System;
interface Sample{
     void Display();
}
class InterDele : Sample{
    public void Display(){
        Console.WriteLine("Display");
    }
    public delegate void Sum(int a,int b);
    public void Add(int a, int b){
        Console.WriteLine(a+b);
    }
    static void Main(){
        InterDele id=new InterDele();
        Sum s=new Sum(id.Add);
        s(34,23);
        id.Display();
    }
}