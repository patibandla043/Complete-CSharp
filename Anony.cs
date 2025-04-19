using System;
class Anony{
    public delegate void show(string str);
    public delegate void Add(int a, int b);
    static void Main(){
        string s3="Bindu";
        show s1=delegate(string s){
            Console.WriteLine(s);
            Console.WriteLine(s3);
        };
        Add a=delegate(int x,int y){
            Console.WriteLine(x+y);
            Console.WriteLine(s3);
        };
        s1("Priya");
        a(23,45);
    }
}
