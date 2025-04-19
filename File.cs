using System;
using System.IO;
class File{
    static void Main(){
        try{
            string path="C:\\Users\\hi\\Desktop\\Qis.txt";
            using(StreamWriter w1=new StreamWriter(path)){
                w1.WriteLine("Heeelloooooooooo");
            }
        }
        catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("File created and text appended");
        
    }
}