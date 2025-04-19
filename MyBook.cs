using System;
abstract class Book{
    public string title;
    public abstract void setTitle(string s);
    public string getTitle(){
        return title;
    }
}
class MyBook : Book{
    public override void setTitle(string s){
        title=s;
    }
    static void Main(){
        MyBook b=new MyBook();
        b.setTitle(Console.ReadLine());
        Console.WriteLine("The title : "+b.getTitle());
    }
}