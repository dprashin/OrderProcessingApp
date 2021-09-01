using OrderProcessingApp;
using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class OrderProcessorTest {
        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip_For_Physical_Payment() {
            //Arrange
            OrderProcessor orderProcessor = new OrderProcessor();
            Product physicalProduct = new Product() { Name = "Football", Price = 233.2};
            physicalProduct.PaymentType = PaymentTypes.Physical;

            string expected = "Generating a packing slip for physical product.";
 
            //Act
            string actual = orderProcessor.ProcessPayment(physicalProduct);

            //Act
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip_For_Book_Payment() {
            //Arrange
            OrderProcessor orderProcessor = new OrderProcessor();
            Product bookProduct = new Product() { Name = "Football", Price = 633.4 };
            bookProduct.PaymentType = PaymentTypes.Book;

            string expected = "Generating a packing slip for book product.";

            //Act
            string actual = orderProcessor.ProcessPayment(bookProduct);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
