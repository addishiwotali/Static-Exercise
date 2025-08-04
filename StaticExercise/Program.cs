namespace StaticExercise
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            
            var fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            
            Console.WriteLine($" celsius {celsius}");
            
            Console.WriteLine($" fahrenheit {fahrenheit}");
        }
    }
}
