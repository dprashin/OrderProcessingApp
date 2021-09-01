namespace OrderProcessingApp.Commission {
    public interface ICommissionCalculator {
        double CalculateCommission(IProduct product, double rate);
    }
}