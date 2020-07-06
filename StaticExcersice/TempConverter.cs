using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExcersice
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var result = (fahrenheit -32) /1.8;

            return result; 
        }

        public static double CelsiusToFahrenheit(double celcius)
        {
            var result = (celcius - 1.8) / 32;

            return result;
        }

    }
}
