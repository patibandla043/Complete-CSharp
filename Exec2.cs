using System;
class Exec2{
	static void Main(string[] args){
		try{
			Console.WriteLine("Enter a number");
			int num = Convert.ToInt32(Console.ReadLine());
			int c=10/num;
			Console.WriteLine(c);
		}
		catch(Exception e){
			if(e is FormatException|| e is DivideByZeroException)
			{
				Console.WriteLine(e.Message);
			}
			else{
				throw new Exception("negative number ");;
			}
		}
	}
}