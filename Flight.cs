using System;
namespace p1{
    class FlightBook{
        public static int availableSeats;
        public static void reserveSeats(int reserve){
            availableSeats=availableSeats-reserve;
            Console.WriteLine("Reserved seats in flight: "+reserve);
            Console.WriteLine("Available seats in flight : "+availableSeats);
        }
    }
}
namespace p2{
    using p1;
    class Cancelled{
        public static void cancelledSeats(int cancel){
            FlightBook.availableSeats=FlightBook.availableSeats+cancel;
            Console.WriteLine("Cancelled seats in flight: "+cancel);
            Console.WriteLine("The remaining seats in flight: "+FlightBook.availableSeats);
        }
    }
}
namespace p3{
    using p1;
    using p2;
    class Flight{
        static void Main(string[] args){
            int rese,canc;
            if (!int.TryParse(args[0], out rese) || !int.TryParse(args[1], out canc))
            {
                Console.WriteLine("Invalid input. Please provide integers.");
                return;
            }

            Console.Write("Total no.of seats in flight: ");
            FlightBook.availableSeats=Convert.ToInt32(Console.ReadLine());
            FlightBook.reserveSeats(rese);
            Cancelled.cancelledSeats(canc);
        }
    }
}