using Domain;
using Repository.Interface;
using System;
using System.Collections.Generic;

namespace AppBL
{
    public class AppLogic
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IAccountRepository _accountRepo;

        public AppLogic(ICustomerRepository customerRepo, IAccountRepository accountRepo)
        {
            _customerRepo = customerRepo;
            _accountRepo = accountRepo;
        }

        public Customer CreateCustomer(Customer custInfo)
        {
            return _customerRepo.CreateCust(custInfo);
        }

        public void DeleteCustomer(Customer custInfo)
        {
            _customerRepo.DeleteCust(custInfo);
        }

        public Customer GetCustomerByID(String custID)
        {
            return _customerRepo.GetCustByID(custID);
        }

        public BankAccount CreateAccount(Customer custInfo)
        {
            return _accountRepo.CreateAccount(custInfo);
        }
        public void DeleteAccountByID(String accountNo)
        {
            _accountRepo.DeleteAccountByID(accountNo);
        }
        public void DeleteAccountByCustID(String custID)
        {
            _accountRepo.DeleteAccountByCustID(custID);
        }
        public BankAccount GetAccountByID(String accountNo)
        {
            return _accountRepo.GetAccountByID(accountNo);
        }
        public List<BankAccount> GetAccountByCustID(String custID)
        {
            return _accountRepo.GetAccountByCustID(custID);
        }
        public String GenerateIBAN()
        {
            return _accountRepo.GenerateIBAN();
        }
    }
}
