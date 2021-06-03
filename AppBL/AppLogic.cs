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
        private readonly ITransactionRepository _transactionRepo;
        private readonly IConfigRepository _configRepo;
        private BankConfig _bankConfig;

        public AppLogic(ICustomerRepository customerRepo, IAccountRepository accountRepo, ITransactionRepository transactionRepo, IConfigRepository configRepo)
        {
            _customerRepo = customerRepo;
            _accountRepo = accountRepo;
            _transactionRepo = transactionRepo;
            _configRepo = configRepo;
        }

        public Customer CreateCustomer(Customer custInfo)
        {
            return _customerRepo.CreateCust(custInfo);
        }

        public void DeleteCustomer(Customer custInfo)
        {
            _customerRepo.DeleteCust(custInfo);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerRepo.GetAllCust();
        }

        public Customer GetCustomerByID(String custID)
        {
            return _customerRepo.GetCustByID(custID);
        }

        public BankAccount CreateAccount(Customer custInfo)
        {
            return _accountRepo.CreateAccount(custInfo);
        }
        public void DepositeAccount(String accountNo, Double value)
        {
            if (_bankConfig == null) _bankConfig = _configRepo.GetConfig();

            Double fee_amount = value * (_bankConfig.fee_deposite.GetValueOrDefault() / 100);

            BankTransaction trans = new BankTransaction()
            {
                trans_type = "D",
                to_acc = accountNo,
                value = value,
                fee_rate = _bankConfig.fee_deposite.GetValueOrDefault(),
                fee_amount = fee_amount,
                total = value - fee_amount
            };
            _transactionRepo.CreateTransaction(trans);
            _accountRepo.Deposite(accountNo, value - fee_amount);
        }
        public void TransferAccount(String fromAcc, String toAcc, Double value)
        {
            if (_bankConfig == null) _bankConfig = _configRepo.GetConfig();

            Double fee_amount = value * (_bankConfig.fee_transfer.GetValueOrDefault() / 100);

            BankTransaction trans = new BankTransaction()
            {
                trans_type = "T",
                from_acc = fromAcc,
                to_acc = toAcc,
                value = value,
                fee_rate = _bankConfig.fee_deposite.GetValueOrDefault(),
                fee_amount = fee_amount,
                total = value - fee_amount
            };
            _transactionRepo.CreateTransaction(trans);
            _accountRepo.Withdraw(fromAcc, value - fee_amount);
            _accountRepo.Deposite(toAcc, value - fee_amount);
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
