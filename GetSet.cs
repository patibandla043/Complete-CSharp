using System;
class GetSet{
    private string name;
    private int marks;
    public int Marks{
        get{
            return marks;
        }
        set{
            marks=value;
        }
    }
    public string Name{
        get{
            return name;
        }
        set{
            name=value;
        }
    }
    static void Main(){
        GetSet gs=new GetSet();
        gs.name="priya";
        gs.marks=100;
        Console.WriteLine(gs.name);
        Console.WriteLine(gs.marks);
    }
}