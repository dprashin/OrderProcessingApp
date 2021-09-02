using OrderProcessingApp.Email;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Models {
    public class MembershipUpgrade : IProduct {
        public string Name { get; set; }
        public double Price { get; set; }
        public int MembershipNumber { get; set; }
        public IOrderProcessor PaymentProcessor { get; set; } = new MembershipUpgradeOrderProcessor();
    }
}
