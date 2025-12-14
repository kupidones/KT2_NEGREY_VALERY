using System;
public class Car
{
    public string Model;
    private int _year;
    public int Year
    {
        get { return _year; }
        set
        {
            if (value >= 1886)
                _year = value;
            else
                Console.WriteLine("Год выпуска не может быть меньше 1886");
        }
    }
    public void StartEngine()
    {
        Console.WriteLine($"Машина {Model}, год {Year}, заводится...");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Model = "Tesla Model S";
        car1.Year = 2020;
        car1.StartEngine();
        Car car2 = new Car();
        car2.Model = "Ford Model T";
        car2.Year = 1908;
        car2.StartEngine();
    }
}
