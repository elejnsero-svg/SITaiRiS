using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Strategy
{
    public class GroundDeliveryStrategy : IDeliveryStrategy
    {
        public string Name => "Наземная доставка";

        public DeliveryResult Calculate(Parcel parcel)
        {
            double cost = 50 + parcel.WeightKg * 20 + parcel.DistanceKm * 0.5;
            int days = 1 + (int)(parcel.DistanceKm / 300) + (int)parcel.WeightKg;
            return new DeliveryResult(cost, days);
        }
    }
}