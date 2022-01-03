using design_patterns.Patterns.ObserverPattern.Abstract;

namespace design_patterns.Patterns.ObserverPattern.Concrete
{
    public class CurrentConditions : IObserver, IDisplay
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }        
        public IObservable Observable { get; set; }

        public CurrentConditions(IObservable observable)
        {
            this.Observable = observable;
            this.Observable.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Tempreature: {Temperature} Humidity: {Humidity}");
        }

        public void Update(float pressure, float temperature, float humidity)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;

            this.Display();
        }
    }
}
