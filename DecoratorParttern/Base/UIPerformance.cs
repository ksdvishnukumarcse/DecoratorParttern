using DecoratorParttern.Interfaces;

namespace DecoratorParttern.Base
{
    /// <summary>
    /// UIPerformance
    /// </summary>
    /// <seealso cref="DecoratorParttern.Interfaces.IPerformance" />
    public class UIPerformance : IPerformance
    {
        /// <summary>
        /// Does the performance improvement.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public string DoPerformanceImprovement()
        {
            return $"Do UI Performance";
        }
    }
}
