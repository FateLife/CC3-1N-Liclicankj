using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_Liclicankj
{
    public class Hotel
    {
        public string HotelName { get; }
        public string Location { get; }
        private List<HotelRoom> rooms = new List<HotelRoom>();

        public Hotel(string name, string location, List<HotelRoom> hotelRooms)
        {
            HotelName = name;
            Location = location;
            rooms = hotelRooms;
        }

        public void ReserveRoom(HotelRoom room)
        {
            room.Status = true;
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Hotel {HotelName} - Available Rooms");
            foreach (HotelRoom room in rooms)
            {
                if (!room.Status)
                {
                    Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }

        public void DisplayBookedRooms(Guest guest)
        {
            Console.WriteLine($"Hotel {HotelName} - Booked Rooms");
            foreach (Reservation reservation in guest.Reservations)
            {
                Console.WriteLine($"  Room {reservation.Room.RoomNumber}, Style: {reservation.Room.Style}, Price: {reservation.Room.BookingPrice}");
            }
        }
    }
}