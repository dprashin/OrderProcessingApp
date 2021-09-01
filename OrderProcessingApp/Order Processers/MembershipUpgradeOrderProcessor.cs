namespace OrderProcessingApp.Models {
    public class MembershipUpgradeOrderProcessor : IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            return $"Your memberhip is upgraded for - {product.Name}.";
        }
    }
}