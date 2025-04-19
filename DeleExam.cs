using System;
class Exec13{
	public delegate int Show(int x,int y);
	static void Main(string[] args){
		Show s1=delegate(int a,int b){
			return a+b;
		};
		int result=s1(23,57);
		Console.WriteLine(result);
	}
}
		