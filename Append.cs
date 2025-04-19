using System;
using System.IO;
class Append{
    static void Main(){
        
            string path="C:\\Users\\hi\\Desktop\\Qis.txt";
            using(StreamWriter w1=new StreamWriter(path,true)){
                w1.WriteLine("I want to append the text");
                
            }
        
        Console.WriteLine("Success");
    }
}