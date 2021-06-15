using System;

namespace AbtractFactory
{
    public class IGH :IHotelSystem<Hotel>
    {
        public void Find(int Id)
        {
            Console.WriteLine(("Busqueda por Id") + Id);
        }
    }
}