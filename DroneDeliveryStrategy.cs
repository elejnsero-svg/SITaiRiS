using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Strategy
{
    public class DroneDeliveryStrategy : IDeliveryStrategy
    {
        public string Name => "Доставка дроном";

        public DeliveryResult Calculate(Parcel parcel)
        {
            double cost = 300 + parcel.WeightKg * 60 + parcel.DistanceKm * 0.8;
            int days = 1 + (int)(parcel.DistanceKm / 500);
            return new DeliveryResult(cost, days);
        }
    }
}