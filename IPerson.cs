using System;
using System.Collections.Generic;
namespace BankingApp
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        string Fullname { get; }
        void AddAccount(IAccount account);
        List<IAccount> Accounts();
    }
}
