using System;
using System.IO;
class Readall{
    static void Main(){
        try{
            string dest="C:\\Users\\hi\\Desktop\\Bpriya.txt";
            string[] lines=File.ReadAllLines(dest);
            foreach(string l1 in lines){
                Console.WriteLine(l1);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}