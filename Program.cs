using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            HotelFactory<Hotel> factory = new HotelFactory<Hotel>();
            Hilton hotelHilton = factory.Create<Hilton>();
            hotelHilton.Find(2);

        }
    }
}
