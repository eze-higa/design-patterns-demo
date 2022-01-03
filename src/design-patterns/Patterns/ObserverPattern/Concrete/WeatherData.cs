using design_patterns.Patterns.ObserverPattern.Abstract;

namespace design_patterns.Patterns.ObserverPattern.Concrete
{
    public class WeatherData : IObservable
    {
        public ICollection<IObserver> Observers { get; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public WeatherData()
        {
            this.Observers = new List<IObserver>();
        }
        public void Notify()
        {
            foreach(var observer in Observers)
            {
                observer.Update(Pressure, Temperature, Humidity);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }
        public void MeasuresChanged() 
        {
            this.Notify();
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            this.MeasuresChanged();
        }
    }
}
