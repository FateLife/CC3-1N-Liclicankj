using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_Liclicankj
{
    public class Reservation
    {
        public long ReservationNumber { get; } = new Random().NextInt64();
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public HotelRoom Room { get; }
        public int DurationInDays { get { return (int)(EndTime - StartTime).TotalDays; } }
        public decimal Total { get { return Room.BookingPrice * DurationInDays; } }

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
        }
    }
}