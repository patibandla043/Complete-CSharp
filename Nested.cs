using System;
class Nest{
    public sealed virtual void Add(){
        Console.WriteLine("heloo");
    }
    public class Nest1{
        public override void Add(){
            Console.WriteLine("hiii");
        }
    }
}
class Nested{
    static void Main(){
        Nest.Nest1 n=new Nest.Nest1();
        n.Add();
    }
   
}