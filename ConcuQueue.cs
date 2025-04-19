using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class ConcuQueue{
    static void Main(){
        ConcurrentQueue<int> cs =new ConcurrentQueue<int>();
        Parallel.For(0,10,i => {
            cs.Enqueue(i);
            Console.WriteLine(i);
        });
        Console.Write("Dequeue elements ");
        while(cs.TryDequeue(out int result)){
            Console.WriteLine(result);
        }
    }
}