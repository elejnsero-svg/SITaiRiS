using DeliveryApp.Models;

namespace DeliveryApp.Patterns.Strategy
{
    public class SeaDeliveryStrategy : IDeliveryStrategy
    {
        public string Name => "Морская доставка";

        public DeliveryResult Calculate(Parcel parcel)
        {
            double cost = 100 + parcel.WeightKg * 10 + parcel.DistanceKm * 0.3;
            int days = 3 + (int)(parcel.DistanceKm / 200) + (int)(parcel.WeightKg * 2);
            return new DeliveryResult(cost, days);
        }
    }
}
