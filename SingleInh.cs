using System;
class Priya{
    public void Show(){
        Console.WriteLine("Show method");
    }
}
class SingleInh : Priya{
    public void display(){
        Console.WriteLine("Display method");
    }
    static void Main(){
        SingleInh si= new SingleInh();
        si.display();
        si.Show();
    }
}