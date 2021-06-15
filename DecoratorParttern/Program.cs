using DecoratorParttern.Base;
using DecoratorParttern.Decorators;
using DecoratorParttern.Interfaces;
using System;

namespace DecoratorParttern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DB Performance

            Console.WriteLine("Performing DB Performance Options");

            IPerformance dbPerformance = new DBPerformance();

            IndexPerformance indexDbPerformance = new IndexPerformance(dbPerformance);
            var indexPerformanceResult = indexDbPerformance.DoPerformanceImprovement();
            Console.WriteLine(indexPerformanceResult);

            CachePerformance cachePerformance = new CachePerformance(dbPerformance);
            var cachePerformanceResult = cachePerformance.DoPerformanceImprovement();
            Console.WriteLine(cachePerformanceResult);

            Console.WriteLine();

            #endregion

            #region API Performance

            Console.WriteLine("Performing API Performance Options");

            IPerformance apiPerformance = new APIPerformance();

            cachePerformance = new CachePerformance(apiPerformance);
            cachePerformanceResult = cachePerformance.DoPerformanceImprovement();
            Console.WriteLine(cachePerformanceResult);
            Console.WriteLine();
            #endregion

            #region UI Performance

            Console.WriteLine("Performing UI Performance Options");

            IPerformance uiPerformance = new UIPerformance();

            BasicOptimization basicOptimization = new BasicOptimization(uiPerformance);
            var basicOptimizationResult = basicOptimization.DoPerformanceImprovement();
            Console.WriteLine(basicOptimizationResult);

            cachePerformance = new CachePerformance(uiPerformance);
            cachePerformanceResult = cachePerformance.DoPerformanceImprovement();
            Console.WriteLine(cachePerformanceResult);
            Console.WriteLine();
            #endregion

            Console.ReadLine();
        }
    }
}
