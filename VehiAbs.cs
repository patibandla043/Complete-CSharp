using System;
abstract class VehiAbs{
    public abstract void Vehicle(int wheels,string motor);
}
class Bike:VehiAbs{
    public override void Vehicle(int wheels,string motor){
        Console.WriteLine("The number of wheels in a "+motor+ " are "+wheels);
    }
    static void Main(string []args){
     int wheels1;
     /*if (!int.TryParse(args[0], out wheels1))
        {
            Console.WriteLine("Invalid wheels argument. Please provide an integer.");
            return;
        }*/

     Bike b=new Bike();
     b.Vehicle(wheels1,args[1]);   
    }
}