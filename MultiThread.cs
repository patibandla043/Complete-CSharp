using System;
class MultiThread{
    static void M1(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Good Morning");
        }
    }
    static void M2(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Good Afternoon");
        }
    }
    static void M3(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Good Evening");
        }
    }
    static void Main(){
        M1();
        M2();
        M3();
    }
}