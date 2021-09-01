namespace OrderProcessingApp {
    public interface IOrderProcessor {
        string ProcessPayment(IProduct product);
    }
}