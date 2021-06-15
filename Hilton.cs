using System;

namespace AbstractFactoryPattern
{
    public class Hilton:IHotelSystem<HotelBaseSystem>
    {
        public void Find(int Id)
        {
            Console.WriteLine(("Busqueda por Id: ") + Id);
        }
    }
}