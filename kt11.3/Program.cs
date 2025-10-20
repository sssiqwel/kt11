using System;

public interface IPrintable<T>
{
    void Print();
}

public class Student : IPrintable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void Print()
    {
        Console.WriteLine($"Student: Name = {Name}, Age = {Age}, Grade = {Grade:F2}");
    }
}

public struct Vector : IPrintable<Vector>
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Print()
    {
        Console.WriteLine($"Vector: X = {X:F2}, Y = {Y:F2}, Z = {Z:F2}");
    }
}

public class Program
{
    public static void PrintItem<T>(T item) where T : IPrintable<T>
    {
        item.Print();
    }

    static void Main()
    {

        var student = new Student("John Doe", 20, 85.5);
        Console.WriteLine("Student information:");
        PrintItem(student);


        var vector = new Vector(1.5, 2.3, 3.7);
        Console.WriteLine("\nVector information:");
        PrintItem(vector);

        Console.WriteLine("\nAll printable items:");
        IPrintable<Student> student1 = new Student("Alice", 22, 92.0);
        IPrintable<Student> student2 = new Student("Bob", 21, 78.5);

        student1.Print();
        student2.Print();
    }
}