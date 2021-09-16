namespace RandomAlgos.Tests
{
    using NUnit.Framework;
    using FluentAssertions;

    public class AlgosTests
    {
        // Only negatives
        // Only zeroes

        [TestCase(new[] { 3, 2, 2, 0, 2, 0, 5, 4 }, 1)]
        [TestCase(new[] { 3, 3, -2, 1, 1, 6, -3, 4, -3, 1 }, 2)]
        public void LowestMissingNatural_ReceivesArrayWithDuplicated_ExpectedOutcome(int[] input, int expectedOutcome)
        {
            var classUnderTest = new Algos();

            var result = classUnderTest.LowestMissingNatural(input);

            result.Should().Be(expectedOutcome);
        }

        [TestCase(new[] { 3, 4, 1 }, 2)]
        [TestCase(new[] { -3, -1, 0, 1, 2, 4, 7, 4, 2, 7 }, 3)]
        public void LowestMissingNatural_ReceivesValidInputArray_ExpectedOutcome(int[] input, int expectedOutcome)
        {
            var classUnderTest = new Algos();

            var result = classUnderTest.LowestMissingNatural(input);

            result.Should().Be(expectedOutcome);
        }

        [TestCase(new[] { 3, 4, 1, 2 })]
        [TestCase(new[] { 3, 4, 0, 1, 2 })]
        [TestCase(new[] { -2, -4, 0, 5, 2, 3, 1, 4 })]
        public void LowestMissingNatural_ReceivesNonMissingNaturalArray_ReturnsNull(int[] input)
        {
            var classUnderTest = new Algos();

            var result = classUnderTest.LowestMissingNatural(input);

            result.Should().BeNull();
        }

        [TestCase(new[] { 1, 2, 3 }, 2)]
        [TestCase(new[] { 1, 5, 4, 3, 1, 2 }, 4)]
        public void MaxProfit_ReceivesRisingQuotes_ExpectedOutcome(int[] input, int expectedOutcome)
        {
            var classUnderTest = new Algos();

            var result = classUnderTest.MaxProfit(input);

            result.Should().Be(expectedOutcome);
        }

        [TestCase(new[] { 3, 2, 1 })]
        [TestCase(new[] { 10, 7, 5, 4, 2, 1 })]
        public void MaxProfit_ReceivesDroppingQuotes_ReturnsZero(int[] input)
        {
            var classUnderTest = new Algos();

            var result = classUnderTest.MaxProfit(input);

            result.Should().Be(0);
        }
    }
}