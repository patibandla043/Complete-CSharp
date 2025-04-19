using System;
using System.Collections;
class Arraylist{
    static void Main(){
        ArrayList al=new ArrayList();
        al.Add(12);
        al.Add("Heelooo");
        al.Add(true);
        al.Add(23.54);
        al.Insert(4,"hiii");
        foreach(var o in al){              //foreach(object o in al){  both are workable
            Console.WriteLine(o);
        }
    }
}