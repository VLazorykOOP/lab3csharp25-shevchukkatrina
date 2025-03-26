using System;
using System.Collections.Generic;
using System.Linq;

abstract class Detal
{
    public string Name { get; set; }
    public double Weight { get; set; }

    protected Detal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public abstract void Show();
}

class Mechanism : Detal
{
    public int Gears { get; set; }

    public Mechanism(string name, double weight, int gears)
        : base(name, weight)
    {
        Gears = gears;
    }

    public override void Show()
    {
        Console.WriteLine($"Механізм: {Name}, Вага: {Weight} кг, Кількість шестерень: {Gears}");
    }
}

class Vuzol : Detal
{
    public string Material { get; set; }

    public Vuzol(string name, double weight, string material)
        : base(name, weight)
    {
        Material = material;
    }

    public override void Show()
    {
        Console.WriteLine($"Вузол: {Name}, Вага: {Weight} кг, Матеріал: {Material}");
    }
}

class Vyrib : Detal
{
    public bool IsCertified { get; set; }

    public Vyrib(string name, double weight, bool isCertified)
        : base(name, weight)
    {
        IsCertified = isCertified;
    }

    public override void Show()
    {
        Console.WriteLine($"Виріб: {Name}, Вага: {Weight} кг, Сертифіковано: {(IsCertified ? "Так" : "Ні")}");
    }
}