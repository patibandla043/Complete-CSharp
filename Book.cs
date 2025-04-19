using System;
class Book{
    int BookID ;
    
    string Title;
    
    string Author ;
    
    decimal Price ;
    
    int CopiesAvailable;
    void  DisplayDetails(){
        Console.WriteLine("BookID "+BookID);
        Console.WriteLine("Title "+Title);
        Console.WriteLine("Author "+Author);
        Console.WriteLine("Price "+Price);
        Console.WriteLine("Copies "+CopiesAvailable);
    }
    void CalculatetotalValue() {
        decimal v=Price * CopiesAvailable;
        Console.WriteLine("Total Value "+v);
    }
    static void Main(){
        Book b = new Book();
        Console.Write("Enter Book ID : ");
        b.BookID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Title: ");
        b.Title = Console.ReadLine();
        Console.Write("Enter Author: ");
        b.Author = Console.ReadLine();
        Console.Write("Enter Price: ");
        b.Price =Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter CopiesAvailable: ");
        b.CopiesAvailable = Convert.ToInt32(Console.ReadLine());
        b.DisplayDetails();
        b.CalculatetotalValue();
    }
}