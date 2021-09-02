using OrderProcessingApp.Email;

namespace OrderProcessingApp.Models {
    public class MembershipUpgradeOrderProcessor : EmailSender, IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            string emailConfirmation = SendEmail("Email confirmation: ");
            return $"{emailConfirmation} Your memberhip is upgraded for - {product.Name}.";
        }
    }
}