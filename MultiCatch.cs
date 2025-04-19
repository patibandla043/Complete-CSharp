using System;
class MultiCatch{
    static void Main(){
        try{
            int a=4;
            Console.WriteLine("Enter b value");
            int b=Convert.ToInt32(Console.ReadLine());
            if(b<0){
                throw new Exception("Negative Number is not allowed");
            }
            Console.WriteLine(a/b);

        }
        catch(DivideByZeroException e){
            Console.WriteLine(e.StackTrace);
        }
        catch(FormatException e){
            Console.WriteLine(e.StackTrace);
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Heeloo");
    }
}