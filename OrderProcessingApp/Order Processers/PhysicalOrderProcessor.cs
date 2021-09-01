using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp {

    public class PhysicalOrderProcessor : IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            string result = $"Generating a packing slip for - {product.Name}.";

            return result;
        }
    }
}
