using System;
class MultiCatch{
    static void Main(){
        try{
            Console.WriteLine("Enter a value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b=Convert.ToInt32(Console.ReadLine());
            if(b<0 ){
                throw new Exception("Negative Number is not allowed");
            }
            Console.WriteLine(a/b);

        }
        catch(DivideByZeroException e){
            Console.WriteLine(e);
        }
        catch(FormatException e){
            Console.WriteLine(e.StackTrace);
        }
        
        Console.WriteLine("Heeloo");
    }
}