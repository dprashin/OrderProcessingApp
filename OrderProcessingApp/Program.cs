using System;

namespace OrderProcessingApp {
    public class Program {
        static void Main(string[] args) {
            PhysicalProduct physicalProduct = new PhysicalProduct { Name = "Football", Price = 500 };
            string physicalPaymentMessage = physicalProduct.PaymentProcessor.ProcessPayment(physicalProduct);
            Console.WriteLine(physicalPaymentMessage + "\n");
        }
    }
}
