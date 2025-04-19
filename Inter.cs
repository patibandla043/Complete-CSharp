using System;
interface i1{
    void Add();
    void Show();
}
class Inter : i1{
    public void Add(){
        Console.WriteLine("Add Method");
    }
    public void Show(){
        Console.WriteLine("Show method");
    }
    static void Main(){
        Inter i=new Inter();
        i.Add();
        i.Show();
    }
}