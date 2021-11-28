using System;

namespace ConsoleApp38
{
    class TemperatureConverter
    {
        static double ConvertFahrenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your body temperature in Fahren degrees: ");
            double temperature = double.Parse(Console.ReadLine());
            temperature = ConvertFahrenheitToCelsius(temperature);
            Console.WriteLine("Your body temperature in Celsius degree is {0}.", temperature);
            if (temperature >= 37)
            {
                Console.WriteLine("You are ill!");
            }
        }
    }
}
