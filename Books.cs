using System;
class Books{
    public string bname;
    public string bauthor;
    public int bquan;
    public Books(string bname,string bauthor,int bquan){
        this.bname=bname;
        this.bauthor=bauthor;
        this.bquan=bquan;
        if (bquan >10){
            Console.WriteLine("Cannot add more than 10 books");
        }
        else{
            for(int i=0;i<bquan;i++){
                Console.WriteLine(bname);
            }
        }
    }
    static void Main(string[] args){
        int quan;
        /*if(!int.TryParse(args[2],out quan))
        {
            Console.WriteLine("provide integer");
            return;
        }*/
        
        Books bs=new Books(args[0],args[1],quan);
    }
}