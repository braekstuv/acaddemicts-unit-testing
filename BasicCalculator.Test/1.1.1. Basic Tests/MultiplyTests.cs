using Xunit;

namespace BasicCalculator.Test._1._1._1._Basic_Tests
{
    public class MultiplyTests
    {
        [Fact]
        public void Multiplying_OneByOne_ReturnsOne()
        {
            //Arrange
            var sut = new Calculator();
            var x = 1;
            var y = 1;
            var expected = 1;

            //Act
            var actual = sut.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplying_TenByMinusFive_ReturnsMinusFifty()
        {
            //Arrange
            var sut = new Calculator();
            var x = -5;
            var y = 10;
            var expected = -50;

            //Act
            var actual = sut.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplying_OneByZero_ReturnsZero()
        {
            //Arrange
            var sut = new Calculator();
            var x = 1;
            var y = 0;
            var expected = 0;

            //Act
            var actual = sut.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}