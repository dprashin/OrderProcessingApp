using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp {
    public class OrderProcessor {
        public string ProcessPayment(Product product) {
            string result;
            if (product.PaymentType == PaymentTypes.Physical) {
                result = $"Generating a packing slip for physical product.";
            } else if (product.PaymentType == PaymentTypes.Book) {
                result = $"Generating a duplicate packing slip for the royalty department.";
            } else if (product.PaymentType == PaymentTypes.Membership) {
                result = $"Activating membership.";
            } else {
                result = "";
            }
            return result;
        }
    }
}
