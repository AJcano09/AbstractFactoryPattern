using System;

namespace AbstractFactoryPattern
{
    
    /// <summary>
    /// Concrete Factories
    /// </summary>
    public  class HotelBaseSystem:IHotelFactory<HotelBaseSystem>
    {
        //HotelBaseSystem
        public THotelSystem Build<THotelSystem>() where THotelSystem : IHotelSystem<HotelBaseSystem>, new()
        {
            Console.WriteLine("Creating Hotel  : "+ typeof(THotelSystem));
            return new THotelSystem();
        }
    }
}