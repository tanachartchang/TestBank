using Domain;
using System;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IAccountRepository
    {
        BankAccount CreateAccount(Customer custInfo);
        void DeleteAccountByID(String accountNo);
        void DeleteAccountByCustID(String custID);
        BankAccount GetAccountByID(String accountNo);
        List<BankAccount> GetAccountByCustID(String custID);
        String GenerateIBAN();
    }
}