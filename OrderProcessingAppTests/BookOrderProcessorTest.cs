using OrderProcessingApp;
using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessingAppTests {
    public class BookOrderProcessorTest {
        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip_For_Book_Payment() {
            //Arrange
            Book bookProduct = new Book() { Name = "Harry Porter", Price = 633.4 };

            string expected = "Generating a duplicate packing slip for the royalty department. Book ordered: Harry Porter.";

            //Act
            string actual = bookProduct.PaymentProcessor.ProcessPayment(bookProduct);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
