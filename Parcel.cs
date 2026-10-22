using System;

namespace DeliveryApp.Models
{
    public class Parcel
    {
        public string Name { get; private set; }
        public double WeightKg { get; private set; }
        public double DistanceKm { get; private set; }

        public Parcel(string name, double weightKg, double distanceKm)
        {
            Name = name;
            WeightKg = weightKg;
            DistanceKm = distanceKm;
        }

        public override string ToString()
        {
            return string.Format("«{0}» ({1} кг, {2} км)", Name, WeightKg, DistanceKm);
        }
    }
}