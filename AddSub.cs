using System;
class AddSub{
int a=10,b=20;
static int x=60,y=50;
void display(){
Console.WriteLine(a+b);
Console.WriteLine(x-y);
}
void display2(){
int a=40,b=30;
static int x=60,y=50;
Console.WriteLine(a+b);
Console.WriteLine(x-y);
}
static void Main(string[] args){
AddSub a1=new AddSub();
a1.display();
a1.display2();
}
}