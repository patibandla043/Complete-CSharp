// To print current thread

using System;
using System.Threading;
class ThreadName{
    static void Main(){
        Thread t1=Thread.CurrentThread;
        t1.Name="Bindu priya";
        Console.WriteLine(t1.Name);
    }
}