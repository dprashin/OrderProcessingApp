using System;
using Xunit;

namespace OrderProcessingAppTests {
    public class ProductsTests {
        [Fact]
        public void PaymentProcesser_Should_Generate_Packing_Slip() {
            //Arrange
            PhysicalProduct product = new PhysicalProduct();
            string expected = "Generating a packing slip for - Football - purchase";

            //Act

            //Act
        }
    }
}
