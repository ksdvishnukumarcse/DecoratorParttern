using DecoratorParttern.Interfaces;

namespace DecoratorParttern.AbstractDecorator
{
    public abstract class PerformanceDecorator : IPerformance
    {
        private readonly IPerformance _performance;

        public PerformanceDecorator(IPerformance performance)
        {
            _performance = performance;
        }

        public virtual string DoPerformanceImprovement()
        {
            return _performance.DoPerformanceImprovement();
        }
    }
}
