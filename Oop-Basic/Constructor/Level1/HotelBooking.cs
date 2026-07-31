using System;

namespace Level1
{
    class HotelBooking
    {
        string guestName;
        string roomType;
        int nights;

        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        public HotelBooking(HotelBooking p1)
        {
            guestName = p1.guestName;
            roomType = p1.roomType;
            nights = p1.nights;
        }

        public void Display()
        {
            Console.WriteLine("Guest Name : " + guestName);
            Console.WriteLine("Room Type : " + roomType);
            Console.WriteLine("Nights : " + nights);
        }

    }
}