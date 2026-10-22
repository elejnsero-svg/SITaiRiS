namespace DeliveryApp.Models
{
    public class DeliveryResult
    {
        public double Cost { get; }
        public int Days { get; }

        public DeliveryResult(double cost, int days)
        {
            Cost = cost;
            Days = days;
        }
    }
}