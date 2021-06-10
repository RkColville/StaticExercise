using System;

namespace StaticExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Calling Fahrenheit to Celsius temp converter method:

            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Hello, the current degrees in Celsius is {celsius}");

            // Calling Celsius to Fahrenheit temp converter method:
            var Fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Hello, the current degrees in fahrenheit is {Fahrenheit}");
        }
    }
}
