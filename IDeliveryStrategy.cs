using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Strategy
{
    public interface IDeliveryStrategy
    {
        string Name { get; }
        DeliveryResult Calculate(Parcel parcel);
    }
}
