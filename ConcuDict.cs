using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class ConcuDict{
    static void Main(){
        ConcurrentDict<int,string> cs =new ConcurrentDict<int,string>();
        Parallel.For(0,10,i => {
            cs.TryAdd(i);
            Console.WriteLine(i);
        });
        foreach(var kvp in cs)
        Console.WriteLine(kvp.key +" "+kvp.value);
        
    }
}