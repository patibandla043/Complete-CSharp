using System;
class Str{

    static void Main(){
        string s=new string("Hai".ToCharArray());
        string s1=new string("Hai".ToCharArray());
        string s3="hai";
        string s4="hai";
        Console.WriteLine(s.Equals(s1));
        Console.WriteLine(s3.Equals(s1));
        Console.WriteLine(s.Equals(s4));
        Console.WriteLine(s==s1);
        Console.WriteLine(s3==s1);
        Console.WriteLine(s==s1);
        Console.WriteLine(object.ReferenceEquals(s1,s4));
        Console.WriteLine(object.ReferenceEquals(s,s1));
        Console.WriteLine(s1.CompareTo(s3));
    }
}