using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_Liclicankj
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotels = new List<Hotel>();
        private List<User> users = new List<User>();
        private List<Reservation> reservations = new List<Reservation>();

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            Reservation reservation = new Reservation(startTime, endTime, room);
            reservations.Add(reservation);
            guest.AddReservation(reservation);
            hotel.ReserveRoom(room);
        }

        public void DisplayHotels()
        {
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"  {hotel.HotelName}, {hotel.Location}");
            }
        }

        public void DisplayAvailableRooms(Hotel hotel)
        {
            hotel.DisplayAvailableRooms();
        }

        public void DisplayBookedRooms(Hotel hotel, Guest guest)
        {
            hotel.DisplayBookedRooms(guest);
        }

        public void DisplayReservationDetails(long reservationNumber)
        {
            Reservation reservation = reservations.Find(r => r.ReservationNumber == reservationNumber);
            if (reservation != null)
            {
                Console.WriteLine($"{reservation.ReservationNumber} Start Time: {reservation.StartTime.ToString("dd/MM/yyyy h:mm:ss tt")}, End Time: {reservation.EndTime.ToString("dd/MM/yyyy h:mm:ss tt")}, Duration: {reservation.DurationInDays}, Total: {reservation.Total}");
            }
            else
            {
                Console.WriteLine("Reservation not found.");
            }
        }
    }
}