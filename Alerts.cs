using System;


delegate void Notify(string message);

class Alerts
{
    
    static void SendEmail(string message)
    {
        Console.WriteLine("Email: " + message);
    }

    static void SendSMS(string message)
    {
        Console.WriteLine("SMS: " + message);
    }

    static void Main()
    {
        
        Notify email = SendEmail;
        Notify sms = SendSMS;

        
        email("Hello, this is an email!");
        sms("Hello, this is an SMS!");

        
        Notify both = email + sms;
        both("Hello, this is both email and SMS!");
    }
}
