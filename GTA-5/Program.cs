using System;
using System.Collections.Generic;

// Основной класс Транспорт
class Transport
{
    public string Model { get; }

    public Transport(string model)
    {
        Model = model;
    }

    public virtual void ActivateEngine()
    {
        Console.WriteLine($"Engine of transport {Model} started.");
    }
}

// Класс Автомобиль
class Car : Transport
{
    public string Brand { get; }

    public Car(string model, string brand) : base(model)
    {
        Brand = brand;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Car engine {Brand} {Model} started.");
    }
}

// Класс Мотоцикл
class Motorcycle : Transport
{
    public string Type { get; }

    public Motorcycle(string model, string type) : base(model)
    {
        Type = type;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Motorcycle engine {Type} {Model} started.");
    }
}

// Класс Вертолет
class Helicopter : Transport
{
    public string Manufacturer { get; }

    public Helicopter(string model, string manufacturer) : base(model)
    {
        Manufacturer = manufacturer;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Helicopter engine {Manufacturer} {Model} started.");
    }
}

// Класс Самолет
class Airplane : Transport
{
    public string Airline { get; }

    public Airplane(string model, string airline) : base(model)
    {
        Airline = airline;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Airplane engine {Airline} {Model} started.");
    }
}

// Класс Мопед
class Moped : Transport
{
    public string Style { get; }

    public Moped(string model, string style) : base(model)
    {
        Style = style;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Moped engine {Style} {Model} started.");
    }
}

// Класс Катер
class Motorboat : Transport
{
    public string BoatType { get; }

    public Motorboat(string model, string boatType) : base(model)
    {
        BoatType = boatType;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Motorboat engine {BoatType} {Model} started.");
    }
}

// Класс Трамвай
class Tram : Transport
{
    public string City { get; }

    public Tram(string model, string city) : base(model)
    {
        City = city;
    }

    public override void ActivateEngine()
    {
        Console.WriteLine($"Tram engine in {City} {Model} started.");
    }
}

class Program
{
    static void Main()
    {
        List<Transport> vehicles = new List<Transport>
        {
            new Car("Civic", "Honda"),
            new Car("Model S", "Tesla"),
            new Motorcycle("Ninja", "Sport"),
            new Motorcycle("Harley", "Cruiser"),
            new Helicopter("H145", "Airbus"),
            new Airplane("Boeing 747", "Delta"),
            new Moped("Vespa", "Classic"),
            new Motorboat("Speedster", "Speedboat"),
            new Tram("T-1000", "New York")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.ActivateEngine();
        }
    }
}