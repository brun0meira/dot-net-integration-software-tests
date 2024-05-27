using System;

namespace Temperature
{
    public static class ConversorTemperature
    {
        public static double FahrenheitParaCelsius(double temperature)
            => Math.Round((temperature - 32) / 1.8, 2);
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            double fahrenheit = 68; // Example temperature in Fahrenheit
            double celsius = ConversorTemperature.FahrenheitParaCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsius} degrees Celsius.");
        }
    }
}