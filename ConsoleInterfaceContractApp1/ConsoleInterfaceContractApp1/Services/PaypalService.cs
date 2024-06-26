﻿

namespace ConsoleInterfaceContractApp1.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        double IOnlinePaymentService.Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        double IOnlinePaymentService.PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
