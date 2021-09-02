using OrderProcessingApp.Email;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessingAppTests {
    public class EmailSenderTest {
        [Fact]
        public void SendEmail_Should_Send_Email_With_Empty_Message() {
            //Arrange
            EmailSender emailSender = new EmailSender();

            string expected = "";

            //Act
            string actual = emailSender.SendEmail("");

            //Act
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SendEmail_Should_Send_Email_With_Success_Message() {
            //Arrange
            EmailSender emailSender = new EmailSender();

            string expected = "Email sent.";

            //Act
            string actual = emailSender.SendEmail("Email sent.");

            //Act
            Assert.Equal(expected, actual);
        }
    }
}
