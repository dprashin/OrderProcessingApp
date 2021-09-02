using OrderProcessingApp;
using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class PhysicalOrderProcessorTests {
        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip_For_Physical_Payment() {
            //Arrange
            PhysicalProduct physicalProduct = new PhysicalProduct { Name = "Football", Price = 500 };
            string expected = "Generating a packing slip for - Football.";

            //Act
            string actual = physicalProduct.PaymentProcessor.ProcessPayment(physicalProduct);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
