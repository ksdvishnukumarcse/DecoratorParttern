using DecoratorParttern.Interfaces;

namespace DecoratorParttern.Base
{
    /// <summary>
    /// DBPerformance
    /// </summary>
    /// <seealso cref="DecoratorParttern.Interfaces.IPerformance" />
    public class DBPerformance : IPerformance
    {
        /// <summary>
        /// Does the performance improvement.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public string DoPerformanceImprovement()
        {
            return $"Do DB Performance";
        }
    }
}
