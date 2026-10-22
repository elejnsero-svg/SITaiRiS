using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Factory
{
    public class DroneTransportFactory : ITransportFactory
    {
        public Transport CreateTransport() => new Drone();
    }
}