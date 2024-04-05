using CC3-1N-Liclicankj;
using System;
using System.Collections.Generic;

namespace CC3-1N-Liclicankj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and add hotels
            List<HotelRoom> yananRooms = new List<HotelRoom>();
            HotelRoom room1 = new HotelRoom(101, RoomStyle.TwinRoom, 1500);
            HotelRoom room2 = new HotelRoom(102, RoomStyle.KingRoom, 3000);
            yananRooms.Add(room1);
            yananRooms.Add(room2);
            Hotel hotelYanan = new Hotel("Hotel Yanan", "123 GStreet, Takaw City", yananRooms);

            List<HotelRoom> hotel456Rooms = new List<HotelRoom>();
            HotelRoom hotel456Room1 = new HotelRoom(101, RoomStyle.QueenRoom, 2000);
            HotelRoom hotel456Room2 = new HotelRoom(102, RoomStyle.QueenRoom, 2000);
            hotel456Rooms.Add(hotel456Room1);
            hotel456Rooms.Add(hotel456Room2);
            Hotel hotel456 = new Hotel("Hotel 456", "Session Road, Baguio City", hotel456Rooms);

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(hotelYanan);
            hms.AddHotel(hotel456);

            // Display hotels
            hms.DisplayHotels();

            // Display available rooms
            hms.DisplayAvailableRooms(hotelYanan);

            // Create a guest and make a reservation
            Guest terry = new Guest("Terry", "Addr 1", "terry@email.com", 63919129);
            hms.RegisterUser(terry);
            hms.BookReservation(hotelYanan, room1, terry, DateTime.Now, new DateTime(2024, 04, 16));

            // Display booked rooms
            hms.DisplayBookedRooms(hotelYanan, terry);

            // Display reservation details
            hms.DisplayReservationDetails(terry.Reservations[0].ReservationNumber);

            // Create a receptionist and make a reservation
            Receptionist anna = new Receptionist("Anna", "Addr 2", "anna@email.com", 67890);
            hms.RegisterUser(anna);
            Reservation res = new Reservation(new DateTime(2024, 05, 01), new DateTime(2024, 05, 06), hotel456Room2);
            anna.BookReservation(terry, res);

            // Display all reservations for the guest
            terry.DisplayReservations();
        }
    }
}