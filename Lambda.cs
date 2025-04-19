using System;
class Exec14{
	public delegate int Show(int x,int y);
	static void Main(){
		Show s1=(a,b)=>a+b;
		int result=s1(23,12);
		Console.WriteLine(result);
	}
}
