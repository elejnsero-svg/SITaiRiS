namespace DeliveryApp.Models
{
    public abstract class Transport
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
    }

    public class Truck : Transport
    {
        public override string Name { get { return "Грузовик"; } }
        public override string Description { get { return "Наземный транспорт"; } }
    }

    public class Airplane : Transport
    {
        public override string Name { get { return "Самолёт"; } }
        public override string Description { get { return "Воздушный транспорт"; } }
    }

    public class Ship : Transport
    {
        public override string Name { get { return "Корабль"; } }
        public override string Description { get { return "Морской транспорт"; } }
    }

    public class Bike : Transport
    {
        public override string Name { get { return "Курьерский велосипед"; } }
        public override string Description { get { return "Курьерская доставка"; } }
    }

    public class Drone : Transport
    {
        public override string Name { get { return "Дрон"; } }
        public override string Description { get { return "Беспилотная доставка"; } }
    }
}