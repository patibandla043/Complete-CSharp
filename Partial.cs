using System;

    public partial class person{
        public string fname{get;set;}
        public string lname{get; set;}
        public void display(){
            Console.WriteLine("Full name : "+fname+lname);
        }
    }
    public partial class person{
        public int age{get; set;}
        public void displayage(){
            Console.WriteLine("Age : "+age);
        }
    }
class Partial{
    static void Main(){
        person pa=new person(){
        fname="Bindu priya ",
        lname="Patibandla",
        age=21
        };
        
        
        pa.display();
        pa.displayage();
    }
}




