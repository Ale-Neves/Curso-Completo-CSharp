using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc_Fixacao.Services
{
    class PayPal : IOnlinePaymentService
    {
        public double paymentFee(double amount)
        {
            return amount + (amount * 0.02);
        }
        public double interest(double amount, int months)
        {
            return (amount + (amount * 0.01)) * months;
        }
    }
}
