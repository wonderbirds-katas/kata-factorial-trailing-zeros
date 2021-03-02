using Xunit;

namespace Kata.Logic.Tests
{
    public class KataTest
    {
        [Fact]
        public void TrailingZeros_ReturnsZero()
        {
            Assert.Equal(0, Kata.TrailingZeros());
        }
    }
}