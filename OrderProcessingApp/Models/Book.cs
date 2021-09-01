using OrderProcessingApp.Commission;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Models {
    public class Book : IProduct {
        public string Name { get; set; }
        public double Price { get; set; }
        public IOrderProcessor PaymentProcessor { get; set; } = new BookOrderProcessor();
        public ICommissionCalculator CommissionCalculator { get; set; } = new CommissionCalculator();
    }
}
