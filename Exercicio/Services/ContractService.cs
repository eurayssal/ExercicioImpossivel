using ExercicioDeFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Services
{
    public class ContractService
    {
        public Contract contract { get; set; }
        public IOnlinePaymentService _onlinePaymentService;
        public void ProcessContract(Contract contract, int months)
        {
            //DateTime contractMonths = contract.Date.AddMonths(months);
            double contractValue = contract.TotalValue / months;
            for (int i = 1; i < months; i++)
            {
                double installment = _onlinePaymentService.Interest(contractValue, months);
                double paymentFee = _onlinePaymentService.PaymentFee(installment);

            }
        }
    }
}
