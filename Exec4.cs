using System;
class Exec5{
	void Checknum(int num1,int num2){
		if(num2==0){
			throw new DivideByZeroException("number is not divisible");
		}
		int result=num1/num2;
		Console.WriteLine("Correct number "+result);
	}
	public static void Main(){
		Exec5 e1=new Exec5();
		try{
			e1.Checknum(10,4);
		}
		catch(Exception e){
			if(e is FormatException|| e is DivideByZeroException){
				Console.WriteLine(e.Message);
			}else{
				throw;
			}
		}
	}
}
