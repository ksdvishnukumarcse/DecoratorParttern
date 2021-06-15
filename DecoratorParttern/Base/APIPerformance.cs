using DecoratorParttern.Interfaces;

namespace DecoratorParttern.Base
{
    /// <summary>
    /// APIPerformance
    /// </summary>
    /// <seealso cref="DecoratorParttern.Interfaces.IPerformance" />
    public class APIPerformance : IPerformance
    {
        /// <summary>
        /// Does the performance improvement.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public string DoPerformanceImprovement()
        {
            return $"Do API Performance";
        }
    }
}
