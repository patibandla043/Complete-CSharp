//throws is not supported in c#.
using System;
class Exec3{
	static void Checknum(int num){
		if(num==0){
			throw new DivideByZeroException("number is not divisible");
		}
		int result=10/num;
		Console.WriteLine("Correct number "+result);
	}
	public static void Main(){
		//Exec3 e1=new Exec3();
		try{ 
			int a=Convert.ToInt32(Console.ReadLine());
			Checknum(a);
		}
		/*catch(DivideByZeroException e){
			Console.WriteLine(e.Message);
		}*/
		finally{
			Console.WriteLine("Finally");
		}
	}
}
			
		