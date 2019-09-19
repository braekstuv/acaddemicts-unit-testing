using Xunit;

namespace BasicCalculator.Test._1._1._1._Basic_Tests
{
    public class AddTests
    {
        [Fact]
        public void Adding_OneToOne_ReturnsTwo()
        {
            //Arrange
            var sut = new Calculator(); // sut stands for System Under Test
            var x = 1;
            var y = 1;
            var expected = 2; //Always use a specific expected result (i.e. never calculate this)

            //Act
            var actual = sut.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Adding_TenToMinusFive_ReturnsFive()
        {
            //Arrange
            var sut = new Calculator();
            var x = -5;
            var y = 10;
            var expected = 5;

            //Act
            var actual = sut.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Adding_OneToZero_ReturnsOne()
        {
            //Arrange
            var sut = new Calculator();
            var x = 1;
            var y = 0;
            var expected = 1;
            //Act
            var actual = sut.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}