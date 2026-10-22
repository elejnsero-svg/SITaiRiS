using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Strategy
{
    public class AirDeliveryStrategy : IDeliveryStrategy
    {
        public string Name => "Авиадоставка";

        public DeliveryResult Calculate(Parcel parcel)
        {
            double cost = 200 + parcel.WeightKg * 50 + parcel.DistanceKm * 1.2;
            int days = 1 + (int)(parcel.DistanceKm / 1500);
            return new DeliveryResult(cost, days);
        }
    }
}