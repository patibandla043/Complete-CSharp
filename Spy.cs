using System;
class Spy{
    static void Main(){
        int sum=0;
        int mul=1;
        int x=0;
        int num=0;
        Console.WriteLine("enter number  : ");
        int a=Convert.ToInt32(Console.ReadLine());
        num=a;
        while(a!=0){
            int n=a%10;
            sum=sum+n;
            mul=mul*n;
            a=a/10;
        }
        
        if (sum==mul){
            Console.WriteLine("It is a Spy Number");
            while(num!=0){
                int m=num%10;
                x=x*10+m;
                num=num/10;
            }
            Console.WriteLine("Given number in reverse number : "+x);
        }
        else{
            Console.WriteLine("It is not a spy number");
        }

    }
}