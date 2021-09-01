using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApp.Commission {
    public class CommissionCalculator : ICommissionCalculator {
        public double CalculateCommission(IProduct product, double rate) {
            double commissionAmout;
            if (product.Price > 0 && rate > 0)
                commissionAmout = product.Price * rate / 100;
            else
                commissionAmout = 0;
            return commissionAmout;
        }
    }
}
