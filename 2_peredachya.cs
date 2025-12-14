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
    public static void ChangeBookTitle(Book b)
    {
        b.Title = "1984";
    }
    public static void ReassignBook(Book b)
    {
        b = new Book();
        b.Title = "Мастера и Маргарита";
    }

    public static void Main(string[] args)
    {
        Book myBook = new Book();
        myBook.Title = "Преступление и наказание";
        myBook.Pages = 500;
        Console.WriteLine("До изменения:");
        myBook.PrintInfo();
        ChangeBookTitle(myBook);
        Console.WriteLine("После изменения названия через ChangeBookTitle:");
        myBook.PrintInfo();
        ReassignBook(myBook);
        Console.WriteLine("После вызова ReassignBook:");
        myBook.PrintInfo();
    }
}
