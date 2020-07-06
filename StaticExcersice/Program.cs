using System;

namespace StaticExcersice
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(60);


            Console.WriteLine($"Celcius {celcius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(50);

            Console.WriteLine($"Fahrenheit {fahrenheit}");

        }
    }
}
