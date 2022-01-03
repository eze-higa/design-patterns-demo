namespace design_patterns.Patterns.ObserverPattern.Abstract
{
    public interface IObservable
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void Notify();
    }
}
