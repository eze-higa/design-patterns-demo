namespace design_patterns.Patterns.ObserverPattern.Abstract
{
    public interface IObserver
    {
        public void Update(float pressure, float temperature, float humidity);
    }
}
