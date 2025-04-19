using System;
using System.Threading;
class MultiJoin{
    static void Add(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Hiii");
        }
    }
    static void Main(){
        Thread t1=new Thread(Add);
        t1.Start();
        t1.Join();
        Console.WriteLine("Thread Finised");
    }
}