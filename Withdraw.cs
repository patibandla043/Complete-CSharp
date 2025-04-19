using System;
abstract class WithdrawalAmount{
    public abstract void withdraw(int bal);
} 
class FixedAmount{
    public static int fix=10000;
}
class Withdraw : WithdrawalAmount{
    public override void withdraw(int bal)
    {
        int amo=FixedAmount.fix;
        amo=amo-bal;
        Console.WriteLine("Mainatin minimum balance 10000");
        Console.WriteLine("The available balance : "+amo);
    }
    static void Main(string[] args){
        int withdrawal;
        if (!int.TryParse(args[0], out withdrawal))
        {
            Console.WriteLine("Invalid withdrawal amount. Please provide an integer.");
            return;
        }

        Withdraw wd=new Withdraw();
        wd.withdraw(withdrawal);
    }
}
