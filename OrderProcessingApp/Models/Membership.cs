using OrderProcessingApp.Email;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Models {
    public class Membership : IProduct {
        public string Name { get; set; }
        public double Price { get; set; }
        public IOrderProcessor PaymentProcessor { get; set; } = new MembershipOrderProcessor();
        public IEmailSender EmailSender { get; set; } = new EmailSender();
    }
}
