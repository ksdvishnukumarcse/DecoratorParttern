using DecoratorParttern.AbstractDecorator;
using DecoratorParttern.Interfaces;

namespace DecoratorParttern.Decorators
{
    /// <summary>
    /// BasicOptimization
    /// </summary>
    /// <seealso cref="DecoratorParttern.AbstractDecorator.PerformanceDecorator" />
    public class BasicOptimization : PerformanceDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicOptimization"/> class.
        /// </summary>
        /// <param name="performance">The performance.</param>
        public BasicOptimization(IPerformance performance) :base(performance)
        {

        }

        /// <summary>
        /// Does the performance improvement.
        /// </summary>
        /// <returns>string</returns>
        public override string DoPerformanceImprovement()
        {
            return $"{base.DoPerformanceImprovement()} with baisc Optimization";
        }
    }
}
