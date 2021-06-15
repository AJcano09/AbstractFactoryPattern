namespace AbstractFactoryPattern
{
    public interface IHotelSystem<THotelFactory>
    {
        void Find(int Id);
    }
}