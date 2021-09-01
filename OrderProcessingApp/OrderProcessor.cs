using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp {
    public class OrderProcessor {
        public string ProcessPayment(Product product) {
            string result;
            if (product.PaymentType == PaymentTypes.Physical) {
                result =  $"Generating a packing slip for physical product.";
            } else if (product.PaymentType == PaymentTypes.Book) {
                result = $"Generating a packing slip for book product.";
            } else {
                result = "";
            }
            return result;
        }
    }
}
