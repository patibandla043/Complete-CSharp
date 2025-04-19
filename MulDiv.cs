using System;
class MulDiv{
int a=10,b=20;
static int x=60,y=50;
void display(){
Console.WriteLine(a*x);
Console.WriteLine(y/b);
}
void display2(){
int a=40,b=30;
//static int x=60,y=50;
Console.WriteLine(a*x);
Console.WriteLine(y/b);
}
static void Main(string[] args){
MulDiv a1=new MulDiv();
a1.display();
a1.display2();
}
}