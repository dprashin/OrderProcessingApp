namespace OrderProcessingApp.Models {
    public class MembershipOrderProcessor : IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            return $"Your memberhip is activated for - {product.Name}.";
        }
    }
}