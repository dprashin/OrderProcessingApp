using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessingAppTests {
    public class MembershipUpgradeOrderProcessorTest {
        [Fact]
        public void PaymentProcesser_Should_Upgrade_Membership_Upgrade_Membership_Payment() {
            //Arrange
            MembershipUpgrade membershipUpgrade = new MembershipUpgrade() { Name = "LinkedIn", Price = 200, MembershipNumber = 101 };

            string expected = "Your memberhip is upgraded for - LinkedIn.";

            //Act
            string actual = membershipUpgrade.PaymentProcessor.ProcessPayment(membershipUpgrade);

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
