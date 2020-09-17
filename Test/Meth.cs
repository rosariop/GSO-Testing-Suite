using System.Linq;
using System.Collections.Generic;

namespace Test
{
    internal static class Meth
    {
        public static double? Median(IEnumerable<int> input)
        {
            if (!CanHandle(input))
            {
                return null;
            }
            var sorted = SortCollection(input);

            return null;
        }

        public static double? Mittelwert(IEnumerable<int> input)
        {
            if (!CanHandle(input))
            {
                return null;
            }

            double sum = 0;
            foreach(var entry in input)
            {
                sum += entry;
            }

            return sum / input.Count();
        }

        public static double? Modus(IEnumerable<int> input)
        {
            if (!CanHandle(input))
            {
                return null;
            }
            return null;
        }

        private static IEnumerable<int> SortCollection(IEnumerable<int> input)
        {
            return input.OrderBy(x => x);
        }

        private static bool CanHandle(IEnumerable<int> input)
        {
            return input != null ? input.Any() : false;
        }
    }
}
