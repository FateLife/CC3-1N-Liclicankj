using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_Liclicankj
{
    public class Guest : User
    {
        public List<Reservation> Reservations { get; } = new List<Reservation>();

        public Guest(string name, string address, string email, int phoneNumber) : base(name, address, email, phoneNumber)
        {
        }

        public void AddReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }

        public void DisplayReservations()
        {
            foreach (Reservation reservation in Reservations)
            {
                Console.WriteLine($"  {reservation.ReservationNumber} Start Time: {reservation.StartTime.ToString("dd/MM/yyyy h:mm:ss tt")}, End Time: {reservation.EndTime.ToString("dd/MM/yyyy h:mm:ss tt")}, Duration: {reservation.DurationInDays}, Total: {reservation.Total}");
            }
        }
    }
}