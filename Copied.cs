using System;
class Copied{
    private string name;
    private int marks;
    public Copied(string name1,int marks1){
        name=name1;
        marks=marks1;
    }
    public Copied(Copied c){
        name=c.name;
        marks=c.marks;
    }
    public string Display{
        get{
            return "my name is "+ name +" my marks are "+ marks.ToString();
        }
    }
    static void Main(){
        Copied cc=new Copied("priya",100);
        Copied c1=new Copied(cc);
        Console.WriteLine(c1.Display);
    }
}