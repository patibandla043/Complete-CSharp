

using System;

class TouristInformation
{
    public string FullName ;
    public int Age ;
    public string EmergencyContact ;
    public string MedicalConditions ;
}

class Tour
{
    static void Main()
    {
        Console.WriteLine("Welcome to the National Park Guided Hike!");

        TouristInformation[] tourists = new TouristInformation[2];

        for (int i = 0; i < 2; i++)
        {
            tourists[i] = new TouristInformation();

            Console.WriteLine("Tourist "+(i + 1) +"- Please provide the following information:");

            Console.Write("Full Name: ");
            tourists[i].FullName = Console.ReadLine();

            Console.Write("Age: ");
            tourists[i].Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Emergency Contact: ");
            tourists[i].EmergencyContact = Console.ReadLine();

            Console.Write("Any Medical Conditions or Allergies (if any): ");
            tourists[i].MedicalConditions = Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine("Tourist Information for the Guided Hike:");
        

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Tourist "+ (i + 1)  +" Details:");
            Console.WriteLine("Name: "+tourists[i].FullName);
            Console.WriteLine("Age: "+tourists[i].Age);
            Console.WriteLine("Emergency Contact: "+tourists[i].EmergencyContact);
            Console.WriteLine("Medical Conditions: "+tourists[i].MedicalConditions);
            
        }
    }
}
