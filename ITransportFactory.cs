using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Factory
{
    public interface ITransportFactory
    {
        Transport CreateTransport();
    }
}