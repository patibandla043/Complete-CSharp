using System;
class Exceptional{
    static void Main(){
        try{
            int a=10;
            int b=0;
            Console.WriteLine(a/b);
        }
        catch(Exception e){
            Console.WriteLine(e);
            Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.Message);
            Console.WriteLine(e.ToString());
        }
    }
}