using Microsoft.Extensions.DependencyModel;
using System.Reflection;

namespace LibraryManagement.Infrastructure.Helpers
{
    public static class CommonHelper
    {
        public static List<T> GetAllInstancesOf<T>()
            => GetAllTypesOf<T>()?.Where(o => !o.IsInterface).Select(o => (T)Activator.CreateInstance(o)).ToList();

        /// <summary>
        /// The GetAllTypesOf.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <returns>The <see cref="IEnumerable{Type}"/>.</returns>
        public static IEnumerable<Type> GetAllTypesOf<T>()
            => GetLoadedType().Where(t => typeof(T).IsAssignableFrom(t));

        /// <summary>
        /// The GetLoadedType.
        /// </summary>
        /// <param name="defineTypes">The defineTypes<see cref="bool"/>.</param>
        /// <returns>The <see cref="IEnumerable{Type}"/>.</returns>
        public static IEnumerable<Type> GetLoadedType(bool defineTypes = false)
        {
            var platform = Environment.OSVersion.Platform.ToString();
            var runtimeAssemblyNames = DependencyContext.Default.GetRuntimeAssemblyNames(platform);

            var assemblies = runtimeAssemblyNames.Select(Assembly.Load);
            return defineTypes ? assemblies.SelectMany(a => a.DefinedTypes) : assemblies.SelectMany(a => a.ExportedTypes);
        }

        public static double GetBusinessDays(DateTime startDate, DateTime endDate)
        {
            double calcBusinessDays = ((endDate - startDate).TotalDays * 5 - (startDate.DayOfWeek - endDate.DayOfWeek) * 2) / 7;

            if (endDate.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startDate.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return Convert.ToInt32(calcBusinessDays);
        }

        public static DateTime AddBusinessDays(DateTime startDate, double businessDays)
        {
            int daysOfWeek = (int)startDate.DayOfWeek;
            double temp = businessDays + daysOfWeek + 1;
            if (daysOfWeek != 0) temp--;
            return startDate.AddDays(Math.Floor(temp / 5) * 2 - daysOfWeek + temp - 2 * Convert.ToInt32(temp % 5 == 0));
        }

        /// <summary>
        /// Calculate Book Penalty
        /// </summary>
        /// <param name="day"></param>
        /// <param name="coefficient"></param>
        /// <returns></returns>
        public static double CalculatePenalty(int day, double coefficient = 0.20)
        {
            //Calculation Penalty
            //1.Day Penalty = (0) * (0.20)
            //2.Day Penalty = (1) * (0.20) + (1.Day Penalty)
            //3.Day Penalty = (1) * (0.20) + (2.Day Penalty)
            //4. Day Penalty = (2) * (0.20) + (3.Day Penalty)
            //And So on

            if (day <= 0)
                return 0;

            return Fib(--day) * coefficient + CalculatePenalty(day);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Fib(int n)
        {
            if (n <= 0)
                return 0;
            if (n <= 2)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
    }
}
