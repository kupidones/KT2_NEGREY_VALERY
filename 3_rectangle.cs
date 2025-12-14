using System;
public class Rectangle
{
    private double _width;
    private double _height;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value > 0) _width = value;
            else Console.WriteLine("Ширина должна быть больше 0");
        }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value > 0) _height = value;
            else Console.WriteLine("Высота должна быть больше 0");
        }
    }
    public double Area()
    {
        return _width * _height;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.Width = 5;
        r.Height = 10;
        Console.WriteLine($"Площадь: {r.Area()}");
    }
}
