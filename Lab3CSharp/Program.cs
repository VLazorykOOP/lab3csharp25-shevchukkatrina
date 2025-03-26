using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1 - Робота з трикутником (ATriangle)");
        Console.WriteLine("2 - Ієрархія класів (Деталь, Механізм, Виріб, Вузол)");

        Console.Write("Ваш вибір: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                RunTask1();
                break;
            case "2":
                RunTask2();
                break;
            default:
                Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                break;
        }
    }

    static void RunTask1()
    {
        Console.WriteLine("\n Робота з масивом трикутників:");

        ATriangle[] triangles = {
        new ATriangle(3, 4, 1),
        new ATriangle(5, 5, 2),
        new ATriangle(6, 8, 3),
        new ATriangle(7, 7, 4),
        new ATriangle(9, 12, 5)
    };

        int isoscelesCount = 0;

        Console.WriteLine("\n Інформація про трикутники:");
        foreach (var triangle in triangles)
        {
            triangle.PrintSides();
            Console.WriteLine($"Периметр: {triangle.GetPerimeter():F2}");
            Console.WriteLine($"Площа: {triangle.GetArea():F2}");
            Console.WriteLine($"Чи є рівнобедреним: {(triangle.IsIsosceles() ? "Так" : "Ні")}\n");

            if (triangle.IsIsosceles()) isoscelesCount++;
        }

        Console.WriteLine($"Кількість рівнобедрених трикутників: {isoscelesCount}");
    }


    static void RunTask2()
    {
        List<Detal> details = new List<Detal>
        {
            new Mechanism("Шестерня", 2.5, 5),
            new Vuzol("Підшипник", 1.2, "Сталь"),
            new Vyrib("Модульний блок", 3.8, true),
            new Mechanism("Редуктор", 4.2, 3),
            new Vuzol("Рама", 7.0, "Алюміній")
        };

        Console.WriteLine("\nСписок деталей до сортування:");
        foreach (var detail in details)
        {
            detail.Show();
        }

        Console.WriteLine("\nСписок деталей після сортування за вагою:");
        details = details.OrderBy(d => d.Weight).ToList();
        foreach (var detail in details)
        {
            detail.Show();
        }
    }
}
