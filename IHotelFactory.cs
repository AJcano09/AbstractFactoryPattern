namespace AbstractFactoryPattern
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    /// <typeparam name="THotelFactory"></typeparam>
    public interface IHotelFactory<THotelFactory>
    {
        THotelSystem Build<THotelSystem>() where THotelSystem : IHotelSystem<THotelFactory>, new();
    }
}