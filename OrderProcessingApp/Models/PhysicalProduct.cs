using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp {
    public class PhysicalProduct : IProduct {
        public string Name { get; set; }
        public double Price { get; set; }
        public IOrderProcessor PaymentProcessor { get; set; } = new PhysicalOrderProcessor();
    }
}
