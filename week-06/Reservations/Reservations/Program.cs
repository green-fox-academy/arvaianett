using System;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservation1 = new Reservation();

            Console.WriteLine("Booking# "+ reservation1.GetCodeBooking() + " for "+ reservation1.GetDowBooking());

            Console.ReadLine();
        }
    }
}
