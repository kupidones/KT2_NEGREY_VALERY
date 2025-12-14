using System;
public class Student
{
    public string Name;
    private int _grade;
    public int Grade
    {
        get { return _grade; }
        set
        {
            if (value >= 1 && value <= 5)
                _grade = value;
            else
                Console.WriteLine("Оценка должна быть в пределах от 1 до 5");
        }
    }
    public void Print()
    {
        Console.WriteLine($"Студент: {Name}, оценка: {Grade}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Иван";
        student.Grade = 5;
        student.Print();
    }
}
