using oop;

Car fortuner = new Car();

fortuner.Name = "Fortuner";
fortuner.Brand = "Toyota";
fortuner.NumberOfWheel = 4;

fortuner.PrintCarInfo();

Car yaris = new Car("Yaris", "Toyota", 4);

// yaris.Name = "Yaris";
// yaris.Brand = "Toyota";
// yaris.NumberOfWheel = 4;

Console.WriteLine(fortuner.Name);