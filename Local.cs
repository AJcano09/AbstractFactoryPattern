using System;

namespace AbstractFactoryPattern
{
    public class Local :IHotelSystem<HotelBaseSystem>
    {
        public void Find(int Id)
        {
            Console.WriteLine(("Busqueda por Id") + Id);
        }
    }
}