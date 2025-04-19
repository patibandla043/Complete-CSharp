using System;
class AddSub1{
int a=10,b=20;
static int x=60,y=50;
void display(){
Console.WriteLine(a+b);
Console.WriteLine(x-y);
Console.WriteLine(a*y);
Console.WriteLine(b/x);
}

static void Main(string[] args){
AddSub1 a1=new AddSub1();
a1.display();
}
}