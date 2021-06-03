using Domain;
using System;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IAccountRepository
    {
        BankAccount CreateAccount(Customer custInfo);
        void Deposite(String accountNo, Double value);
        void Withdraw(String accountNo, Double value);
        void DeleteAccountByID(String accountNo);
        void DeleteAccountByCustID(String custID);
        BankAccount GetAccountByID(String accountNo);
        List<BankAccount> GetAllAccount();
        List<BankAccount> GetAccountByCustID(String custID);
        String GenerateIBAN();
    }
}