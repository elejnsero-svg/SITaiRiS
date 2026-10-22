using System;
using DeliveryApp.Models;
using DeliveryApp.Patterns;
using DeliveryApp.Patterns.Factory;
using DeliveryApp.Patterns.Strategy;

namespace DeliveryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("СЛУЖБА ДОСТАВКИ: демонстрация паттернов");
            Console.WriteLine();

            var parcel = new Parcel("Книги", 5, 1200);
            Console.WriteLine($"Посылка: {parcel}");
            Console.WriteLine();

            Console.WriteLine("Расчёт доставки разными способами (Strategy)");

            var service = new DeliveryService(new GroundDeliveryStrategy());

            Console.WriteLine();
            Console.WriteLine("[Наземная]");
            service.Calculate(parcel);

            Console.WriteLine();
            Console.WriteLine("[Авиа — меняем на лету]");
            service.SetStrategy(new AirDeliveryStrategy());
            service.Calculate(parcel);

            Console.WriteLine();
            Console.WriteLine("[Морская]");
            service.SetStrategy(new SeaDeliveryStrategy());
            service.Calculate(parcel);

            Console.WriteLine();
            Console.WriteLine("[Курьерская]");
            service.SetStrategy(new CourierDeliveryStrategy());
            service.Calculate(parcel);

            Console.WriteLine();
            Console.WriteLine("Новый способ (дрон) — добавлен без правки старого кода");
            service.SetStrategy(new DroneDeliveryStrategy());
            service.Calculate(parcel);

            Console.WriteLine();
            Console.WriteLine("Создание транспорта по типу (Factory Method)");

            ITransportFactory[] factories = new ITransportFactory[]
            {
                new GroundTransportFactory(),
                new AirTransportFactory(),
                new SeaTransportFactory(),
                new CourierTransportFactory(),
                new DroneTransportFactory()
            };

            foreach (var factory in factories)
            {
                service.ShowTransport(factory);
            }

            Console.WriteLine();
            Console.WriteLine("Демонстрация завершена");
            Console.ReadKey();
        }
    }
}