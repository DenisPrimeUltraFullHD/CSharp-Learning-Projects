using System;

namespace cod
{ 
{
    public struct Temperature

    public double? DegreesCelsius;

    public Temperature(double? celsius)
    {
        DegreesCelsius = celsius;
    }

    public bool HasValue() => DegreesCelsius.HasValue;

    public double ToFahrenheit()
    {
        if (!DegreesCelsius.HasValue)
            throw new InvalidOperationException("Температура не задана");

        return DegreesCelsius.Value * 9 / 5 + 32;
    }

    public override string ToString()
    {
        if (!DegreesCelsius.HasValue)
            return "—";

        return $"{DegreesCelsius.Value:F1} °C";
    }
}

class Program
{

    static void Main()
    {
        var t1 = new Temperature(23.456);   // DegreesCelsius = 23.456
        Console.WriteLine(t1.HasValue());   // True
        Console.WriteLine(t1.ToFahrenheit()); // ≈ 74.2
        Console.WriteLine(t1);              // "23.5 °C"

        var t2 = new Temperature(null);     // DegreesCelsius = null
        Console.WriteLine(t2.HasValue());   // False
        Console.WriteLine(t2);              // "—"
                                            // t2.ToFahrenheit(); // бросит InvalidOperationException
    }
}
}