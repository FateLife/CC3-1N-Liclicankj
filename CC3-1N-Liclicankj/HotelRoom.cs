using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_Liclicankj
{
    public class HotelRoom
    {
        public int RoomNumber { get; }
        public RoomStyle Style { get; }
        public decimal BookingPrice { get; }
        public bool Status { get; set; } = false;

        public HotelRoom(int roomNumber, RoomStyle style, decimal bookingPrice)
        {
            RoomNumber = roomNumber;
            Style = style;
            BookingPrice = bookingPrice;
        }
    }
}