using Domain;
using NHibernate;
using NHibernate.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace Repository.Implementation
{
    public class AccountRepository : IAccountRepository
    {
        private String _urlGenIBAN = @"http://randomiban.com/?country=Netherlands";
        private ISession _session;

        public AccountRepository(ISession session)
        {
            _session = session;
        }

        public BankAccount CreateAccount(Customer custInfo)
        {
            var accountInfo = new BankAccount()
            {
                accountNo = GenerateIBAN(),
                custID = custInfo.custID,
                balance = 0
            };
            _session.Save(accountInfo);
            return accountInfo;
        }

        public void Deposite(String accountNo, Double value)
        {
            var q1 = @"UPDATE bank_account SET balance = balance + :val1
                        WHERE account_no = :acc";

            var query = _session.CreateSQLQuery(q1)
                .SetParameter("val1", value )
                .SetParameter("acc", accountNo);
            query.ExecuteUpdate();
        }

        public void Withdraw(String accountNo, Double value)
        {
            var q1 = @"UPDATE bank_account SET balance = balance - :val1
                        WHERE account_no = :acc";

            var query = _session.CreateSQLQuery(q1)
                .SetParameter("val1", value)
                .SetParameter("acc", accountNo);
            query.ExecuteUpdate();
        }

        public void DeleteAccountByID(String accountNo)
        {
            _session.Query<BankAccount>()
            .Where(x => x.accountNo == accountNo)
            .Delete();
        }

        public void DeleteAccountByCustID(String custID)
        {
            _session.Query<BankAccount>()
            .Where(x => x.custID == custID)
            .Delete();
        }

        public BankAccount GetAccountByID(String accountNo)
        {
            var query = from u in _session.QueryOver<BankAccount>()
                        where u.accountNo == accountNo
                        select u;
            return query.List<BankAccount>().FirstOrDefault();
        }

        public List<BankAccount> GetAllAccount()
        {
            var query = from u in _session.QueryOver<BankAccount>()
                        where u.accountNo != null
                        select u;
            return query.List<BankAccount>().ToList();
        }

        public List<BankAccount> GetAccountByCustID(String custID)
        {
            var query = from u in _session.QueryOver<BankAccount>()
                        where u.custID == custID
                        select u;
            return query.List<BankAccount>().ToList();
        }

        public String GenerateIBAN()
        {
            String result = null;
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--disable-extensions");
            //options.AddArgument("test-type");
            //options.AddArgument("--ignore-certificate-errors");
            //options.AddArgument("no-sandbox");
            options.AddArgument("--headless");//hide browser
            using (IWebDriver driver = new ChromeDriver(options))
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                driver.Navigate().GoToUrl(_urlGenIBAN);
                //driver.FindElement(By.Id("gen_button")).SendKeys(Keys.Enter);
                IWebElement firstResult = driver.FindElement(By.Id("demo"));
                result = firstResult.GetAttribute("innerHTML");
            }
            return result;
        }
    }
}