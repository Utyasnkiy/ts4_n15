using System;

class Car {
    public string Brand;
    public int EnginePower;
    public int NumSeats;

    public Car(string brand, int enginePower, int numSeats) {
        Brand = brand;
        EnginePower = enginePower;
        NumSeats = numSeats;
    }

    public double CalculateQuality() {
        return 0.1 * EnginePower - NumSeats;
    }

    public void OutputInfo() {
        Console.WriteLine("Car brand: " + Brand);
        Console.WriteLine("Engine power: " + EnginePower + " kW");
        Console.WriteLine("Number of seats: " + NumSeats);
        Console.WriteLine("Quality (Q): " + CalculateQuality());
    }
}

class CustomCar : Car {
    public int YearOfManufacture;

    public CustomCar(string brand, int enginePower, int numSeats, int yearOfManufacture)
        : base(brand, enginePower, numSeats) {
        YearOfManufacture = yearOfManufacture;
    }

    public new double CalculateQuality() {
        int currentYear = DateTime.Now.Year;
        return base.CalculateQuality() - 1.5 - (currentYear - YearOfManufacture);
    }

    public new void OutputInfo() {
        base.OutputInfo();
        Console.WriteLine("Year of manufacture: " + YearOfManufacture);
        Console.WriteLine("Quality (Qp): " + CalculateQuality());
    }
}


class Program {
    static void Main(string[] args) {
        Car myCar = new Car("Toyota", 100, 5);
        myCar.OutputInfo();

        CustomCar myCustomCar = new CustomCar("BMW", 150, 4, 2015);
        myCustomCar.OutputInfo();
    }
}
