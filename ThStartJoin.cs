using System;
using System.Threading;
class ThStartJoin{
    static void Add(){
        for(int i=0;i<5;i++){
            if(i==3){
                Thread.Sleep(10000);
            }
            Console.WriteLine("Hiii");
        }
    }
    static void M1(){
        Console.WriteLine("Good Morning");
    }
    static void Main(){
        Thread t1=new Thread(Add);
        t1.Start();
        //t1.Join();
        Thread t2=new Thread(M1);
        t2.Start();
        t2.Join();
        Console.WriteLine("Finished");
        
    }
}