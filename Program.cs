using System;

// Level 1 class
class Car {
    // Fields
    public string Brand;
    public int EnginePower;
    public int NumSeats;

    // Constructor
    public Car(string brand, int enginePower, int numSeats) {
        Brand = brand;
        EnginePower = enginePower;
        NumSeats = numSeats;
    }

    // Function to calculate quality (Q)
    public double CalculateQuality() {
        return 0.1 * EnginePower - NumSeats;
    }

    // Function to output information about the car
    public void OutputInfo() {
        Console.WriteLine("Car brand: " + Brand);
        Console.WriteLine("Engine power: " + EnginePower + " kW");
        Console.WriteLine("Number of seats: " + NumSeats);
        Console.WriteLine("Quality (Q): " + CalculateQuality());
    }
}

// Level 2 class (descendant class)
class CustomCar : Car {
    // Additional field
    public int YearOfManufacture;

    // Constructor
    public CustomCar(string brand, int enginePower, int numSeats, int yearOfManufacture)
        : base(brand, enginePower, numSeats) {
        YearOfManufacture = yearOfManufacture;
    }

    // Function to calculate quality (Qp)
    public new double CalculateQuality() {
        int currentYear = DateTime.Now.Year;
        return base.CalculateQuality() - 1.5 - (currentYear - YearOfManufacture);
    }

    // Function to output information about the custom car
    public new void OutputInfo() {
        base.OutputInfo();
        Console.WriteLine("Year of manufacture: " + YearOfManufacture);
        Console.WriteLine("Quality (Qp): " + CalculateQuality());
    }
}

// Example usage
class Program {
    static void Main(string[] args) {
        // Level 1 class usage
        Car myCar = new Car("Toyota", 100, 5);
        myCar.OutputInfo();

        // Level 2 class usage
        CustomCar myCustomCar = new CustomCar("BMW", 150, 4, 2015);
        myCustomCar.OutputInfo();
    }
}
