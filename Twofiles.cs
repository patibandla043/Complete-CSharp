using System;
using System.IO;
class Twofiles{
    static void Main(){
        
            string path1="C:\\Users\\hi\\Desktop\\Qis.txt";
            string path2="C:\\Users\\hi\\Desktop\\Bb.txt";
            using(StreamReader w1=new StreamReader(path1))
            using(StreamReader w2=new StreamReader(path2)){
                string line1,line2;
                while((line1=w1.ReadLine())!=null && (line2=w2.ReadLine())!=null){
                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                }
                
            }
        
        
    }
}