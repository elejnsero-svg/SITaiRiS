using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Factory
{
    public class CourierTransportFactory : ITransportFactory
    {
        public Transport CreateTransport() => new Bike();
    }
}