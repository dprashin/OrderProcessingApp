using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp {
    public class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public PaymentTypes PaymentType { get; set; }
    }
}
