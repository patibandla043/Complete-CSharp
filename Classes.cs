using System;
class classes{
    string colour;
    int price;
    int miles;
     void bike(){
        Console.WriteLine("bikecolour:"+colour);
        Console.WriteLine("bikeprice:"+price);
        Console.WriteLine("bikemiles:"+miles);

    }
    static void Main(){
        classes p=new classes();
        p.colour="black";
        p.miles=56;
        p.price=2000;
        classes q=new classes();
        q.colour="black";
        q.miles=56;
        q.price=2000;
        classes r=new classes();
        r.colour="black";
        r.miles=56;
        r.price=2000;
        p.bike();
        q.bike();
        r.bike();


    }
}