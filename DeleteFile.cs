using System;
using System.IO;
class DeleteFile{
    static void Main(){
        string dest="C:\\Users\\hi\\Desktop\\nn.txt";
        if(File.Exists(dest)){
            File.Delete(dest);
            Console.WriteLine("Success");
        }else{
            Console.WriteLine("File not existed");
        }

    }
}