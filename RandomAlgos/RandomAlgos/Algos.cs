namespace RandomAlgos
{
    using System.Linq;

    public class Algos : IAlgos
    {
        public int? LowestMissingNatural(int[] input)
        {
            input = input
                .Where(i => i > 0)
                .Distinct()
                .OrderBy(i => i)
                .ToArray();

            return GetLowestNaturalNumber(input);
        }

        public int MaxProfit(int[] quotes)
        {
            var currentMax = 0;

            // Local Max
            for (var i = 0; i < quotes.Length; i++)
            {
                for (var j = i; j < quotes.Length - i; j++)
                {
                    var tradeProfit = CalculateProfit(quotes[i], quotes[j]);

                    if (tradeProfit > currentMax)
                    {
                        currentMax = tradeProfit;
                    }
                }
            }

            return currentMax;
        }

        private static int? GetLowestNaturalNumber(int[] sortedArray)
        {
            if (sortedArray[0] != 1)
            {
                return 1;
            }

            for (var i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] + 1 != sortedArray[i + 1])
                {
                    return sortedArray[i] + 1;
                }
            }

            return null;
        }

        private static int CalculateProfit(int a, int b) => a >= b ? 0 : b - a;
    }
}