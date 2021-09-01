using OrderProcessingApp.Models;
using System;

namespace OrderProcessingApp {
    public class Program {
        static void Main(string[] args) {
            PhysicalProduct physicalProduct = new PhysicalProduct { Name = "Football", Price = 500 };
            string physicalPaymentMessage = physicalProduct.PaymentProcessor.ProcessPayment(physicalProduct);
            Console.WriteLine(physicalPaymentMessage + "\n");
            Console.WriteLine("Physical payment - commission amount to the agent: " + physicalProduct.CommissionCalculator.CalculateCommission(physicalProduct, 10) + ".\n");

            Book bookProduct = new Book { Name = "Harry Porter", Price = 336 };
            string bookPaymentMessage = bookProduct.PaymentProcessor.ProcessPayment(bookProduct);
            Console.WriteLine(bookPaymentMessage + "\n");
            Console.WriteLine("Book payment- commission amount to the agent: " + bookProduct.CommissionCalculator.CalculateCommission(bookProduct, 20) + ".\n");
            
            Membership membership = new Membership { Name = "Fitness", Price = 226 };
            string membershipMessage = membership.PaymentProcessor.ProcessPayment(membership);
            Console.WriteLine(membershipMessage + "\n");

            MembershipUpgrade membershipUpgrade = new MembershipUpgrade { Name = "LinkedIn", Price = 333 };
            string membershipUpgradeMessage = membershipUpgrade.PaymentProcessor.ProcessPayment(membershipUpgrade);
            Console.WriteLine(membershipUpgradeMessage + "\n");
        }
    }
}
