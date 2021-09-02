using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessingAppTests {
    public class VideoProductOrderProcessorTest {

        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip_Learning_To_Ski_Payment() {
            //Arrange
            VideoProduct videoProduct = new VideoProduct { Name = "Learning to Ski", Price = 5000 };
            string expected = "Generating a packing slip for - Learning to Ski. Congratuations! A free is \"First Aid\" is also added.";

            //Act
            string actual = videoProduct.PaymentProcessor.ProcessPayment(videoProduct);

            //Act
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip_For_Learning_To_Dance_Payment() {
            //Arrange
            VideoProduct videoProduct = new VideoProduct { Name = "Learning to Dance", Price = 5000 };
            string expected = "Generating a packing slip for - Learning to Dance.";

            //Act
            string actual = videoProduct.PaymentProcessor.ProcessPayment(videoProduct);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
