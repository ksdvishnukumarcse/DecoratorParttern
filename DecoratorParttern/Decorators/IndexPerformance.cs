using DecoratorParttern.AbstractDecorator;
using DecoratorParttern.Interfaces;

namespace DecoratorParttern.Decorators
{
    /// <summary>
    /// IndexPerformance
    /// </summary>
    /// <seealso cref="DecoratorParttern.AbstractDecorator.PerformanceDecorator" />
    public class IndexPerformance:PerformanceDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexPerformance"/> class.
        /// </summary>
        /// <param name="performance">The performance.</param>
        public IndexPerformance(IPerformance performance) :base(performance)
        {

        }

        /// <summary>
        /// Does the performance improvement.
        /// </summary>
        /// <returns>string</returns>
        public override string DoPerformanceImprovement()
        {
            return $"{base.DoPerformanceImprovement()} with Index";
        }
    }
}
