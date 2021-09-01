using OrderProcessingApp;
using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class ProductsTests {
        [Fact]
        public void PaymentProcesser_Should_Generate_Empty_Packing_Slip() {
            //Arrange
            PhysicalProduct product = new PhysicalProduct();
            string expected = "";

            //Act
            string actual = product.ProcessPayment();

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
