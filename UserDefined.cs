using System;
class DrivinglisenseException:Exception{
	public DrivinglisenseException(string message):base(message){
	}
}
class Exec8{
	public void AgeCheck(string name,int age){
		if(age<18){
			throw new DrivinglisenseException("not allowed for applying a driving lisense");
		}
		Console.WriteLine("eligible");
	}
	public static void Main(){
		try{
			Console.WriteLine("enter the name:");
			string name =Console.ReadLine();
			Console.WriteLine("enter the age:");
			int age=int.Parse(Console.ReadLine());
			Exec8 e2=new Exec8();
			e2.AgeCheck(name,age);
		}
		catch(DrivinglisenseException e){
			Console.WriteLine(e.Message);
		}
	}
}