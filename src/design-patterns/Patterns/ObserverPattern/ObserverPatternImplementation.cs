using design_patterns.Patterns.ObserverPattern.Concrete;

namespace design_patterns.Patterns.ObserverPattern
{
    public static class ObserverPatternImplementation
    {
        public static void Run() {
            WeatherData weatherData = new WeatherData();
            CurrentConditions currentConditions = new CurrentConditions(weatherData);
            weatherData.SetMeasurements(30, 50, 1004);
            weatherData.SetMeasurements(26, 40, 1014);
        }
    }
}
