using OrderProcessingApp.Email;

namespace OrderProcessingApp.Models {
    public class MembershipOrderProcessor : EmailSender, IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            string emailConfirmation = SendEmail("Email confirmation: ");
            return $"{emailConfirmation} Your memberhip is activated for - {product.Name}.";
        }
    }
}