using System;
interface i1{
    void show();
    void display();
}
class I2{
    public void print(){
        Console.WriteLine("Print");
    }
}
class TwoInt : I2,i1{
    public void show(){
        Console.WriteLine("Show");
    }
    public void display(){
        Console.WriteLine("display");
    }
    static void Main(){
        TwoInt ti=new TwoInt();
        ti.show();
        ti.print();
        ti.display();
    }
}