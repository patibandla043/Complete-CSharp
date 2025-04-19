using System;
public delegate void Game();
 class AttaDefe{
    public void Attack(){
        Console.WriteLine("Player Attack!");
    }
    public void Defend(){
        Console.WriteLine("Player Defend!");
    }
     static void Main(){
        AttaDefe ad=new AttaDefe();
        Game att=ad.Attack;
        Game def=ad.Defend;
        Console.WriteLine("press 1 for attack and 2 for defend!");
        int input=Convert.ToInt32(Console.ReadLine());
        if (input==1){
            att();
        }
        else if(input==2){
            def();
        }
        Game both=att + def;
        both(); 
    }
}