using System;

public class Kelvin
{
    public double Degree { get; set; }

    public Kelvin(double degree)
    {
        Degree = degree;
    }
}

public class Celsius
{
    public double Degree { get; set; }

    public Celsius(double degree)
    {
        Degree = degree;
    }

    public static implicit operator Kelvin(Celsius c)
    {
        return new Kelvin(c.Degree + 273);
    }
}

public class Program
{
    public static void Main()
    {
        Celsius c = new Celsius(0);
        Kelvin k = c; 

        Console.WriteLine($"Celsius: {c.Degree}°C");
        Console.WriteLine($"Kelvin: {k.Degree}K");
    }
}
