namespace design_patterns.Patterns.DecoratorPattern.Abstract
{
    public abstract class Beverage
    {
        protected string _description;
        public abstract string GetDescription();
        public abstract double Cost();
    }
}
