using System;
class Sample{
    public delegate void display(string s);
}
class DelAno  {
    public static void show(Sample.display x,string name){
        name="Ram"+name;
        x(name);
    }
    static void Main(){
        show(delegate(string name1){
            Console.WriteLine(name1);
        }," Bindu");
    }
}