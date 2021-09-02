namespace OrderProcessingApp.Models {
    public class VideoProductOrderProcessor : IOrderProcessor {
        public string ProcessPayment(IProduct product) {
            string message = $"Generating a packing slip for - {product.Name}.";
            if (product.Name == "Learning to Ski") {
                message += " Congratuations! A free is \"First Aid\" is also added.";
            }
            return message;
        }
    }
}