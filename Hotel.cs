using System;

namespace AbstractFactoryPattern
{
    
    /// <summary>
    /// Concrete Factories
    /// </summary>
    public  class Hotel:IHotelFactory<Hotel>
    {
        public THotelSystem Build<THotelSystem>() where THotelSystem : IHotelSystem<Hotel>, new()
        {
            Console.WriteLine("Creating Hotel  : "+ typeof(THotelSystem));
            return new THotelSystem();
        }
    }
}