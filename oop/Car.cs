namespace oop;

public class Car
{
    // property
    public string Brand { get; set; }
    public string Name { get; set; }
    public int NumberOfWheel { get; set; }
    
    // default constructor
    public Car() { }
    
    // constructor
    public Car(string name, string brand, int numberOfWheel)
    {
        Name = name;
        Brand = brand;
        NumberOfWheel = numberOfWheel;
    }

    public void PrintCarInfo()
    {
        Console.WriteLine($"Hello this is my car, name: {Name} and come from brand: {Brand} and {NumberOfWheel} wheels");
    }
}