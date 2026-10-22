using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Factory
{
    public class AirTransportFactory : ITransportFactory
    {
        public Transport CreateTransport() => new Airplane();
    }
}