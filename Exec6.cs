//class not found exception.
using System;
class Exec6{
	public static void Main(){
		try{
			Console.WriteLine("enter the file name:");
			string filename=Console.ReadLine();
			Type t=Type.GetType(filename);
			if(t==null){
				throw new TypeLoadException("class is not found");
			}
			Console.WriteLine("class found");
		}
		catch(TypeLoadException e){
			Console.WriteLine(e.Message);
		}
	}
}
			
