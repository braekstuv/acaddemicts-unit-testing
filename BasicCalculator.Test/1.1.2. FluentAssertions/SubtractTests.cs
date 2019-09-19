using FluentAssertions;
using Xunit;

namespace BasicCalculator.Test._1._1._2._FluentAssertions
{
    public class SubtractTests
    {
        [Fact]
        public void Subtracting_OneFromOne_ReturnsZero()
        {
            //Arrange
            var sut = new Calculator();
            var x = 1;
            var y = 1;
            var expected = 0;

            //Act
            var actual = sut.Subtract(x, y);

            //Assert
            actual.Should().Be(expected, $"1 - 1 = 0");
        }

        [Fact]
        public void Subtracting_TenFromMinusFive_ReturnsMinusFifteen()
        {
            //Arrange
            var sut = new Calculator();
            var x = -5;
            var y = 10;
            var expected = -15;

            //Act
            var actual = sut.Subtract(x, y);

            //Assert
            actual.Should().Be(expected, $"-5 - 10 = -15");
        }

        [Fact]
        public void Subtracting_OneFromZero_ReturnsMinusOne()
        {
            //Arrange
            var sut = new Calculator();
            var x = 0;
            var y = 1;
            var expected = -1;

            //Act
            var actual = sut.Subtract(x, y);

            //Assert
            actual.Should().Be(expected, $"0 - 1 = -1");
        }
    }
}