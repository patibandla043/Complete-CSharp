using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class ConcuStack{
    static void Main(){
        ConcurrentStack<int> cs =new ConcurrentStack<int>();
        Parallel.For(0,10,i => {
            cs.Push(i);
            Console.WriteLine(i);
        });
        Console.Write("pop elements ");
        while(cs.TryPop(out int result)){
            Console.WriteLine(result);
        }
    }
}