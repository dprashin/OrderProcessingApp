namespace OrderProcessingApp.Models {
    public class BookOrderProcessor : IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            return $"Generating duplicate payment for the royalty department. Book ordered: {product.Name}.";
        }
    }
}