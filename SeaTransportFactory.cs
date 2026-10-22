using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Factory
{
    public class SeaTransportFactory : ITransportFactory
    {
        public Transport CreateTransport() => new Ship();
    }
}