using System;
using System.Collections.Generic;
using System.Text;
using _2_Exerc_Fixacao.Entities;

namespace _2_Exerc_Fixacao.Services
{
    class ContratService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContratService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i=1; i<=months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.paymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
