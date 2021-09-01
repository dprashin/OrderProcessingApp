﻿namespace OrderProcessingApp.Models {
    public class BookOrderProcessor : IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            return $"Generating a duplicate packing slip for the royalty department. Book ordered: {product.Name}.";
        }
    }
}