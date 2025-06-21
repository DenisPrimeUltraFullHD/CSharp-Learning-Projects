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
        var t1 = new Temperature(23.456);  
        Console.WriteLine(t1.HasValue());   
        Console.WriteLine(t1.ToFahrenheit()); 
        Console.WriteLine(t1);           

        var t2 = new Temperature(null);     
        Console.WriteLine(t2.HasValue());   
        Console.WriteLine(t2);             
    }
}
}
