using System;
using BankingApp.Model;
namespace BankingApp
{
    public interface IAccount
    {
        string AccountHolder { get; }
        decimal Balance { get; }
        void Deposit(decimal value);
        void Withdraw(decimal value);
        void Transfer(IAccount account, decimal value);
        void AddAccountHolder(Customer customer);
    }
}
