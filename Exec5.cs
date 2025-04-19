using System;
class Exec6{
	public static int DivideNum(int m,int n){
		if(n==0){
			throw new ArithmeticException("Cannot divide");
		}
		return m/n;
	}
	public static void Main(){
		try{
			Console.WriteLine("enter first number");
			int m=int.Parse(Console.ReadLine());
			Console.WriteLine("enter second number");
			int n=int.Parse(Console.ReadLine());
			Console.WriteLine("Result: "+DivideNum(m,n));
		}
		catch(Exception e){
			if (e is FormatException || e is ArithmeticException){
				Console.WriteLine("caught exception: "+e.Message);
			}
			/*else{
				throw;
			}*/
		}
		finally{
			Console.WriteLine("finally block:This will execute");
		}
	}
}


