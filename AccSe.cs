// we can acess only sealed properties as sealed class ..and can't acess sealed method by creation of object.
using System;
public sealed class Sample{
    public int value =76;
    public void display(){
        Console.WriteLine(value);
    }
}
public class AccSe{
    public void UseSam(){
        Sample sa=new Sample();
        sa.value=100;
        sa.display();
    }
    static void Main(){
        AccSe ase=new AccSe();
        ase.UseSam();
    }
}