namespace StringBuilder.Models;

public class Car : Vehicle
{
    public string brand;
    public string model;
    public double fuelCapacity;
    public double fuelFor1Km;
    public double currentFuel;

    public Car(string model, string brand, double fuelFor1Km, double fuelCapacity, int year) : base(year)
    {
        this.model = model;
        this.brand = brand;
        this.fuelCapacity = fuelCapacity;
        this.fuelFor1Km = fuelFor1Km;
    }

    public string ShowInfo()
    {
        return $"{brand} - {model} - {currentFuel} - {year} - {color}";
    }

    public void Drive(double km)
    {
        if(currentFuel > km * fuelFor1Km)
        {
            currentFuel -= km * fuelFor1Km;
            return;
        }

        Console.WriteLine("Yeterli qeder benzin yoxdur.");
    }
}