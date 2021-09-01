using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp {
    public class OrderProcessor {
        public string ProcessPayment(PhysicalProduct physicalProduct) {
            string result;
            if (physicalProduct.PaymentType == "Physical") {
                result =  $"Generating a packing slip for physical product.";
            } else {
                result = "";
            }
            return result;
        }
    }
}
