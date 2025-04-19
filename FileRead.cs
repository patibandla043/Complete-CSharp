using System;
using System.IO;
class FileRead{
    static void Main(){
            string path="C:\\Users\\hi\\Desktop\\Qis.txt";
            
            
            using(StreamReader w1=new StreamReader(path)){
                string line;
                while((line=w1.ReadLine())!=null){
                    Console.WriteLine(line);
                }
                
            }
        
        
    }
}