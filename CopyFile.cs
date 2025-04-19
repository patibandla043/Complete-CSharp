using System;
using System.IO;
class CopyFile{
    static void Main(){
        string source="C:\\Users\\hi\\Desktop\\Qis.txt";
        string dest="C:\\Users\\hi\\Desktop\\Bp.txt";
        File.Copy(source,dest);
        Console.WriteLine("Success");
    }
}