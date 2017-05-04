using System;

namespace SingleResponsibilityPrinciple.Services
{
    public class AccountService
    {
        public void DepositMoney(Guid accountId, decimal amount) => Console.WriteLine($"{amount} has been deposited to {accountId}");
        public void WithdrawMoney(Guid accountId, decimal amount) => Console.WriteLine($"{amount} has been withdrawn from {accountId}");
    }
}