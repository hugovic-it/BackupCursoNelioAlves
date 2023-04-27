﻿using Console152.Entities;
using Console152.Entities.Exceptions;

namespace Console152;

internal class Program
{
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Chcek-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/M,M/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);

            Console.WriteLine("Reservation: " + reservation);
        }
        catch(DomainException e) {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
    }
}
