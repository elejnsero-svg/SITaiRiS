using System;
using DeliveryApp.Models;
using DeliveryApp.Patterns.Factory;
using DeliveryApp.Patterns.Strategy;

namespace DeliveryApp.Patterns
{
    public class DeliveryService
    {
        private IDeliveryStrategy _strategy;

        public DeliveryService(IDeliveryStrategy initialStrategy)
        {
            _strategy = initialStrategy;
        }

        public void SetStrategy(IDeliveryStrategy strategy)
        {
            _strategy = strategy;
            Console.WriteLine($"  [Стратегия изменена на: {strategy.Name}]");
        }

        public void Calculate(Parcel parcel)
        {
            DeliveryResult result = _strategy.Calculate(parcel);
            Console.WriteLine($"  Способ: {_strategy.Name}");
            Console.WriteLine($"  Стоимость: {result.Cost:F2} руб., срок: {result.Days} дн.");
        }

        public void ShowTransport(ITransportFactory factory)
        {
            Transport transport = factory.CreateTransport();
            Console.WriteLine($"  Транспорт: {transport.Name} — {transport.Description}");
        }
    }
}