using System;

class ATriangle
{
    private int a, b;
    private readonly int color;

    public ATriangle(int a, int b, int color)
    {
        this.a = a;
        this.b = b;
        this.color = color;
    }

    public void PrintSides()
    {
        Console.WriteLine($"Катети: a = {a}, b = {b}, гіпотенуза = {GetHypotenuse():F2}, Колір: {color}");
    }

    public double GetPerimeter()
    {
        return a + b + GetHypotenuse();
    }

    public double GetArea()
    {
        return 0.5 * a * b;
    }

    public bool IsIsosceles()
    {
        return a == b;
    }

    private double GetHypotenuse()
    {
        return Math.Sqrt(a * a + b * b);
    }
}
