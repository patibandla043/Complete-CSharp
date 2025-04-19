using System;
class Null{
    static void Main(){
        int? a=null;
        int? b=38;
        int? c=28;
        int? result=a ?? c ?? b;
        Console.WriteLine(result);
    }

    }
