using OrderProcessingApp;
using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessingAppTests {
    public class CommissionCalculatorTest {
        [Fact]
        public void CalculateCommission_Should_Calculate_Commission_For_Physical_Payment() {
            //Arrange
            PhysicalProduct physicalProduct = new PhysicalProduct { Name = "Guitar", Price = 1500 };
            
            //rate: 10% 
            double expected = 1500 * 15 / 100;

            //Act
            double actual = physicalProduct.CommissionCalculator.CalculateCommission(physicalProduct, 15);

            //Act
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateCommission_Should_Calculate_Commission_For_Book_Payment() {
            //Arrange
            Book bookProduct = new Book { Name = "The Alchemist", Price = 223 };

            //rate: 7.5% 
            double expected = 223 * 7.5 / 100;

            //Act
            double actual = bookProduct.CommissionCalculator.CalculateCommission(bookProduct, 7.5);

            //Act
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-344.0)]
        public void CalculateCommission_Should_Calculate_Commission_With_Commission_Rate_Zero_Invalid_Rate(double rate) {
            //Arrange
            Book bookProduct = new Book { Name = "The Alchemist", Price = 223 };

            //rate: 0% 
            double expected = 0;

            //Act
            double actual = bookProduct.CommissionCalculator.CalculateCommission(bookProduct, rate);

            //Act
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData (0)]
        [InlineData(-344.0)]
        public void CalculateCommission_Should_Calculate_Commission_With_Product_Price_Zero_Invalid_Price(double price) {
            //Arrange
            Book bookProduct = new Book { Name = "The Alchemist", Price = price };

            double expected = 0;

            //Act
            double actual = bookProduct.CommissionCalculator.CalculateCommission(bookProduct, 23);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
