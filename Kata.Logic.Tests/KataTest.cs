using Xunit;

namespace Kata.Logic.Tests
{
    public class KataTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(5, 1)]
        [InlineData(10, 2)]
        [InlineData(25, 6)]
        [InlineData(531, 131)]
        public void TrailingZeros_GivenInput_ReturnsNumberOfZerosInFactorialOfInput(int n, int expected)
        {
            Assert.Equal(expected, Kata.TrailingZeros(n));
        }
    }
}