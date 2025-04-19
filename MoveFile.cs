using System;
using System.IO;
class MoveFile{
    static void Main(){
        string source="C:\\Users\\hi\\Desktop\\Qis.txt";
        string dest="C:\\Users\\hi\\Desktop\\Bpriya.txt";
        File.Move(source,dest);
        Console.WriteLine("Success");
    }
}