using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessingAppTests {
    public class MembershipOrderProcessorTest {
        [Fact]
        public void PaymentProcesser_Should_Activate_Membership_For_Membership_Payment() {
            //Arrange
            Membership membershipPayment = new Membership() { Name = "Fitness", Price = 150 };

            string expected = "Email confirmation:  Your memberhip is activated for - Fitness.";

            //Act
            string actual = membershipPayment.PaymentProcessor.ProcessPayment(membershipPayment);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
