using Xunit;

namespace BasicCalculator.Test._1._1._1._Basic_Tests
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
            Assert.Equal(expected, actual);
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
            Assert.Equal(expected, actual);
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
            Assert.Equal(expected, actual);
        }
    }
}