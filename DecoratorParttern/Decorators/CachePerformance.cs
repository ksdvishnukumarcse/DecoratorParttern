using DecoratorParttern.AbstractDecorator;
using DecoratorParttern.Interfaces;

namespace DecoratorParttern.Decorators
{
    /// <summary>
    /// CachePerformance
    /// </summary>
    /// <seealso cref="DecoratorParttern.AbstractDecorator.PerformanceDecorator" />
    public class CachePerformance : PerformanceDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CachePerformance"/> class.
        /// </summary>
        /// <param name="performance">The performance.</param>
        public CachePerformance(IPerformance performance) :base(performance)
        {

        }

        /// <summary>
        /// Does the performance improvement.
        /// </summary>
        /// <returns>string</returns>
        public override string DoPerformanceImprovement()
        {
            return $"{base.DoPerformanceImprovement()} with Cache";
        }
    }
}
