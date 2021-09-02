namespace OrderProcessingApp {
    public interface IProduct {
        string Name { get; set; }
        double Price { get; set; }
        public IOrderProcessor PaymentProcessor { get; set; }
    }
}