using OrderProcessingApp;
using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class OrderProcessorTest {
        [Theory]
        [InlineData("Physical")]
        public void PaymentProcesser_Should_Generate_Packing_Slip_For_Physical_Payment(string paymentType) {
            //Arrange
            OrderProcessor orderProcessor = new OrderProcessor();
            PhysicalProduct physicalProduct = new PhysicalProduct() { Name = "Football", Price = 233.2};
            physicalProduct.PaymentType = paymentType;

            string expected = "Generating a packing slip for physical product.";
 
            //Act
            string actual = orderProcessor.ProcessPayment(physicalProduct);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
