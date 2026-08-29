using Figures.Core;
using System;
using System.Drawing;

bool exit = false;
while (!exit)
{
    Console.Clear();
    Console.WriteLine("=== AREA AND PERIMETER CALCULATOR ===");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Rectangle");
    Console.WriteLine("4. Triangle");
    Console.WriteLine("5. Parallelogram");
    Console.WriteLine("6. Trapezoid");
    Console.WriteLine("7. Rhombus");
    Console.WriteLine("8. Kite");
    Console.WriteLine("0. Exit");
    Console.Write("Select an option: ");

    string option = Console.ReadLine();
    switch (option)
    {
        case "1": CalculateCircle(); break;
        case "2": CalculateSquare(); break;
        case "3": CalculateRectangle(); break;
        case "4": CalculateTriangle(); break;
        case "5": CalculateParallelogram(); break;
        case "6": CalculateTrapezoid(); break;
        case "7": CalculateRhombus(); break;
        case "8": CalculateKite(); break;
        case "0": exit = true; break;
        default: Console.WriteLine("Invalid option."); break;
    }

    if (!exit)
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}

void CalculateCircle()
{
    try
    {
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        ShowResult(circle);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateSquare()
{
    try
    {
        Console.Write("Enter the side: ");
        double side = double.Parse(Console.ReadLine());
        Square square = new Square(side);
        ShowResult(square);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateRectangle()
{
    try
    {
        Console.Write("Enter the width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        double height = double.Parse(Console.ReadLine());
        Rectangle rect = new Rectangle(width, height);
        ShowResult(rect);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateTriangle()
{
    try
    {
        Console.Write("Enter side A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side C: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter the base (for area): ");
        double baseLength = double.Parse(Console.ReadLine());
        Console.Write("Enter the height (for area): ");
        double height = double.Parse(Console.ReadLine());
        Triangle tri = new Triangle(a, b, c, baseLength, height);
        ShowResult(tri);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateParallelogram()
{
    try
    {
        Console.Write("Enter side A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side B (base): ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = double.Parse(Console.ReadLine());
        Parallelogram p = new Parallelogram(a, b, h);
        ShowResult(p);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateTrapezoid()
{
    try
    {
        Console.Write("Enter side A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter base B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side C: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter base D: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = double.Parse(Console.ReadLine());
        Trapezoid trap = new Trapezoid(a, b, c, d, h);
        ShowResult(trap);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateRhombus()
{
    try
    {
        Console.Write("Enter diagonal 1: ");
        double d1 = double.Parse(Console.ReadLine());
        Console.Write("Enter diagonal 2: ");
        double d2 = double.Parse(Console.ReadLine());
        Rhombus rhombus = new Rhombus(d1, d2);
        ShowResult(rhombus);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void CalculateKite()
{
    try
    {
        Console.Write("Enter diagonal 1: ");
        double d1 = double.Parse(Console.ReadLine());
        Console.Write("Enter diagonal 2: ");
        double d2 = double.Parse(Console.ReadLine());
        Console.Write("Enter side A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side B: ");
        double b = double.Parse(Console.ReadLine());
        Kite kite = new Kite(d1, d2, a, b);
        ShowResult(kite);
    }
    catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
}

void ShowResult(Figure figure)
{
    Console.WriteLine($"\nArea: {figure.GetArea():F2}");
    Console.WriteLine($"Perimeter: {figure.GetPerimeter():F2}");
}
