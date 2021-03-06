using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Exerc_Fixacao.Services
{
    interface IOnlinePaymentService
    {
        double paymentFee(double amount);
        double interest(double amount, int months);
    }
}
