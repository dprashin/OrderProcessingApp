using OrderProcessingApp;
using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class OrderProcessorTest {
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

        //[Fact]
        //public void PaymentProcesser_Should_Generate_Packing_Slip_For_Book_Payment() {
        //    //Arrange
        //    PhysicalOrderProcessor orderProcessor = new PhysicalOrderProcessor();
        //    PhysicalProduct bookProduct = new PhysicalProduct() { Name = "Harry Porter", Price = 633.4 };
           

        //    string expected = "Generating a duplicate packing slip for the royalty department.";

        //    //Act
        //    string actual = orderProcessor.ProcessPayment(bookProduct);

        //    //Act
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void PaymentProcesser_Should_Generate_Packing_Slip_For_Membersip_Payment() {
        //    //Arrange
        //    PhysicalOrderProcessor orderProcessor = new PhysicalOrderProcessor();
        //    PhysicalProduct membershipPayment = new PhysicalProduct() { Name = "Fitness", Price = 228 };
   

        //    string expected = "Activating membership.";

        //    //Act
        //    string actual = orderProcessor.ProcessPayment(membershipPayment);

        //    //Act
        //    Assert.Equal(expected, actual);
        //}
    }
}
