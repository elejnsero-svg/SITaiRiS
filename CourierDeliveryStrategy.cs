using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Strategy
{
    public class CourierDeliveryStrategy : IDeliveryStrategy
    {
        public string Name => "Курьерская доставка";

        public DeliveryResult Calculate(Parcel parcel)
        {
            double cost = 150 + parcel.WeightKg * 30 + parcel.DistanceKm * 2;
            int days = 1 + (int)(parcel.DistanceKm / 100);
            return new DeliveryResult(cost, days);
        }
    }
}