using System;

namespace AbstractFactoryPattern
{
    public  class HotelFactory<THotelFactory> where THotelFactory : IHotelFactory<THotelFactory>, new ()
    {
        public THotelSystem Create<THotelSystem>() where THotelSystem:IHotelSystem<THotelFactory> , new () {
            return new THotelFactory().Build<THotelSystem>();
        }
    }
}