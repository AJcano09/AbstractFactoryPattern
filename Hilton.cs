using System;

namespace AbstractFactoryPattern
{
    public class Hilton:IHotelSystem<Hotel>
    {
        public void Find(int Id)
        {
            Console.WriteLine(("Busqueda por Id: ") + Id);
        }
    }
}