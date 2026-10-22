using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Factory
{
    public class GroundTransportFactory : ITransportFactory
    {
        public Transport CreateTransport() => new Truck();
    }
}