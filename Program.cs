using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            HotelFactory<HotelBaseSystem> factory = new HotelFactory<HotelBaseSystem>();
            Hilton hotelHilton = factory.Create<Hilton>();
            hotelHilton.Find(2);

            var hotelLocal = new HotelFactory<HotelBaseSystem>();
            Local _local = factory.Create<Local>();
            _local.Find(3);


        }
    }
}
