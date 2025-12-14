using System;
public class Book
{
    public string Title;
    private int _pages;
    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value >= 1) 
                _pages = value;
            else 
                Console.WriteLine("Количество страниц должно быть >= 1");
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, страниц: {Pages}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Book b = new Book();
        b.Title = "Преступление и наказание";
        b.Pages = 500;
        b.PrintInfo();
    }
}
