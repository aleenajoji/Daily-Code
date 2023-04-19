// Car class
using System;

public abstract class Car
{
    public long Id { get; set; }
    public string Name { get; set; }

    // Abstract method for calculating drive cost
    public abstract double CalculateDriveCost(double km);
}

// Hatchback class
public class Hatchback : Car
{
    public bool PowerWindows { get; set; }
    public bool AutomaticGear { get; set; }

    // Constructor
    public Hatchback(long id, string name, bool powerWindows, bool automaticGear)
    {
        Id = id;
        Name = name;
        PowerWindows = powerWindows;
        AutomaticGear = automaticGear;
    }

    // Implementing abstract method from Car class
    public override double CalculateDriveCost(double km)
    {
        double cost = 0;
        if (AutomaticGear)
            cost = 12;
        else
            cost = 10;
        return cost * km;
    }
}

// Sedan class
public class Sedan : Car
{
    public bool ABS { get; set; }
    public int BootSpace { get; set; }

    // Constructor
    public Sedan(long id, string name, bool abs, int bootSpace)
    {
        Id = id;
        Name = name;
        ABS = abs;
        BootSpace = bootSpace;
    }

    // Implementing abstract method from Car class
    public override double CalculateDriveCost(double km)
    {
        double cost = 0;
        if (BootSpace > 600)
            cost = 15 + (15 * 0.20);
        else
            cost = 15;
        return cost * km;
    }
}

// UtilityCar class
public class UtilityCar : Car
{
    public bool RearCoolingVents { get; set; }

    // Constructor
    public UtilityCar(long id, string name, bool rearCoolingVents)
    {
        Id = id;
        Name = name;
        RearCoolingVents = rearCoolingVents;
    }

    // Implementing abstract method from Car class
    public override double CalculateDriveCost(double km)
    {
        return 18 * km;
    }
}



class Program
{
    static void Main(string[] args)
    {
        // Taking input for car details
        Console.WriteLine("Enter Car Details:");
        Console.Write("Id: ");
        long id = Convert.ToInt64(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Type (hatchback/sedan/utility): ");
        string type = Console.ReadLine();
        Console.Write("Distance (in km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        // Based on car type, creating the respective object and calculating drive cost
        switch (type.ToLower())
        {
            case "hatchback":
                Console.Write("Power Windows (true/false): ");
                bool powerWindows = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Automatic Gear (true/false): ");
                bool automaticGear = Convert.ToBoolean(Console.ReadLine());
                Hatchback hatchback = new Hatchback(id, name, powerWindows, automaticGear);
                double hatchbackCost = hatchback.CalculateDriveCost(distance);
                Console.WriteLine($"Cost is Rs {Math.Round(hatchbackCost, 0)}");
                break;

            case "sedan":
                Console.Write("ABS Enabled (true/false): ");
                bool absEnabled = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Boot Space (in litres): ");
                int bootSpace = Convert.ToInt32(Console.ReadLine());
                Sedan sedan = new Sedan(id, name, absEnabled, bootSpace);
                double sedanCost = sedan.CalculateDriveCost(distance);
                Console.WriteLine($"Cost is Rs {Math.Round(sedanCost, 0)}");
                break;

            case "utility":
                Console.Write("Rear Cooling Vents (true/false): ");
                bool rearCoolingVents = Convert.ToBoolean(Console.ReadLine());
                UtilityCar utilityCar = new UtilityCar(id, name, rearCoolingVents);
                double utilityCarCost = utilityCar.CalculateDriveCost(distance);
                Console.WriteLine($"Cost is Rs {Math.Round(utilityCarCost, 0)}");
                break;

            default:
                Console.WriteLine("Invalid car type.");
                break;
        }

    }
}

