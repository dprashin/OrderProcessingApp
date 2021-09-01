using OrderProcessingApp;
using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class OrderProcessorTest {
        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip() {
            //Arrange
            OrderProcessor orderProcessor = new OrderProcessor();
            PhysicalProduct physicalProduct = new PhysicalProduct() { Name = "Football", Price = 233.2, PaymentType = "Physical" };

            string expected = "Generating a packing slip for physical product.";

            //Act
            string actual = orderProcessor.ProcessPayment(physicalProduct);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
