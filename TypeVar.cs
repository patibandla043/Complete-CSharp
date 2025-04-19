using System;
class TypeVar{
    int a=10;
    int _underscore=20;
    int @and=76;
    void display(){
        Console.WriteLine(a + _underscore);
        Console.WriteLine(@and * _underscore);
        Console.WriteLine(@and / a);
    }
    static void Main(){
        TypeVar ts = new TypeVar();
        ts.display();
    }
}