namespace RandomAlgos
{
    using System;

    class Program
    {
        static void Main()
        {
            var algos = new Algos();

            Console.WriteLine("==> Lowest Missing Natural");
            int[] input = { 3, 3, -2, 1, 1, 6, -3, 4, -3, 1 }; // Expected 2
            PrintArray("Input array", input);
            var lowestMissingNatural = algos.LowestMissingNatural(input);

            Console.WriteLine(lowestMissingNatural == null
                ? "\nNo missing natural element found"
                : $"\nLowest Missing Natural: {lowestMissingNatural}");

            Console.WriteLine("==> Max Profit");
            var quotes = new[] { 1, 5, 4, 3, 1, 2 }; // Expected 4
            PrintArray("Input array", input);

            var maxProfit = algos.MaxProfit(quotes);
            Console.WriteLine($"Max Profit: {maxProfit}");
        }

        private static void PrintArray(string message, int[] arr)
        {
            Console.WriteLine($"{message}: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}