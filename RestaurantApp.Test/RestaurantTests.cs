using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace RestaurantApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GettingTableNumberWithHighestPrice_ReturnsExpectedResult()
        {
            //Arrange
            var orders = new List<Order>()
            {
                new Order() { TableNumber = 1, TotalPrice = 5 },
                new Order() { TableNumber = 1, TotalPrice = 5 },
                new Order() { TableNumber = 2, TotalPrice = 9 },
            };
            var fakeKitchen = A.Fake<IKitchen>();
            A.CallTo(() => fakeKitchen.GetAllOrders()).Returns(orders);
            var sut = new Restaurant(fakeKitchen);
            var expected = 1;
            //Act
            var actual = sut.GetTableNumberWithHighestTotal();
            //Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void GettingTableNumberWithMostOrders_ReturnsExpectedResult()
        {
            //Arrange
            var orders = new List<Order>()
            {
                new Order() { TableNumber = 1, TotalPrice = 10 },
                new Order() { TableNumber = 2, TotalPrice = 1 },
                new Order() { TableNumber = 2, TotalPrice = 1 },
            };
            var fakeKitchen = A.Fake<IKitchen>();
            A.CallTo(() => fakeKitchen.GetAllOrders()).Returns(orders);
            var sut = new Restaurant(fakeKitchen);
            var expected = 2;
            //Act
            var actual = sut.GetTableNumberWithHighestOrderCount();
            //Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void GettingAverageTotalPrice_ReturnsExpectedResult()
        {
            //Arrange
            var orders = new List<Order>()
            {
                new Order() { TableNumber = 1, TotalPrice = 10 },
                new Order() { TableNumber = 2, TotalPrice = 15 },
                new Order() { TableNumber = 2, TotalPrice = 20 },
            };
            var fakeKitchen = A.Fake<IKitchen>();
            A.CallTo(() => fakeKitchen.GetAllOrders()).Returns(orders);
            var sut = new Restaurant(fakeKitchen);
            var expected = 15;
            //Act
            var actual = sut.GetAverageOrderPrice();
            //Assert
            actual.Should().Be(expected);
        }
    }
}