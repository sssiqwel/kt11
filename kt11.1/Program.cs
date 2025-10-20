using System;

public class Program
{
    public static void Swap<T>(ref T x, ref T y) where T : struct
    {
        T temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int a = 10, b = 20;
        Console.WriteLine($"До Swap: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"После Swap: a = {a}, b = {b}");

        double x = 3.14, y = 2.71;
        Console.WriteLine($"\nДо Swap: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"После Swap: x = {x}, y = {y}");

        bool flag1 = true, flag2 = false;
        Console.WriteLine($"\nДо Swap: flag1 = {flag1}, flag2 = {flag2}");
        Swap(ref flag1, ref flag2);
        Console.WriteLine($"После Swap: flag1 = {flag1}, flag2 = {flag2}");
    }
}