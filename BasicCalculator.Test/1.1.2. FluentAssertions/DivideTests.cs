using FluentAssertions;
using System;
using Xunit;

namespace BasicCalculator.Test._1._1._2._FluentAssertions
{
    public class DivideTests
    {
        [Fact]
        public void Dividing_OneByOne_ReturnsOne()
        {
            //Arrange
            var sut = new Calculator();
            var x = 1;
            var y = 1;
            var expected = 1;

            //Act
            var actual = sut.Divide(x, y);

            //Assert
            actual.Should().Be(expected, $"1 / 1 = 1");
        }

        [Fact]
        public void Dividing_TenByMinusFive_ReturnsMinusPointFive()
        {
            //Arrange
            var sut = new Calculator();
            var x = -5;
            var y = 10;
            var expected = -0.5;

            //Act
            var actual = sut.Divide(x, y);

            //Assert
            actual.Should().Be(expected, $"-5 / 10 = -0.5");
        }

        [Fact]
        public void Dividing_OneByZero_ReturnsCalculationException()
        {
            //Arrange
            var sut = new Calculator();
            var x = 1;
            var y = 0;
            var expectedMessage = "Cannot divide by 0.";
            Action act = () => sut.Divide(x, y);

            //Act && Assert
            act.Should().Throw<CalculationException>("1 / 0 is not possible.")
                .WithMessage(expectedMessage);
        }
    }
}