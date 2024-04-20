using System;

interface IDrivable
{
    void Start();
    void Stop();
    void Drive();
}

class Car : IDrivable
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped");
    }

    public void Drive()
    {
        Console.WriteLine("Car is being driven");
    }
}

class Bicycle : IDrivable
{
    public void Start()
    {
        Console.WriteLine("Bicycle started");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stopped");
    }

    public void Drive()
    {
        Console.WriteLine("Bicycle is being ridden");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        InvokeDrive(new Car());
        InvokeDrive(new Bicycle());
    }

    public static void InvokeDrive(IDrivable vehicle)
    {
        vehicle.Start();
        vehicle.Drive();
        vehicle.Stop();
    }
}
