using System;
class Over{
    private string name;
    private int marks;
    Over(){
        Console.WriteLine("Helooooooooo");
    }
    Over(string name1){
        name=name1;
    }
    Over(string name1,int marks1){
        name=name1;
        marks=marks1;
    }
    Over(Over ol){
        name=ol.name;
        marks=ol.marks;
    }
    public void display(){
        Console.WriteLine("Name : "+name + " Marks : "+marks);
    }
    static void Main(){
        new Over();
        //o.display();
        Over o1=new Over("Priya");
        o1.display();
        Over o2=new Over("Priya",100);
        o2.display();
        Over o3=new Over(o2);
        o3.display();

    }
}