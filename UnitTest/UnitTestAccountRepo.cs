using AppBL;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NHibernate;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using TestBank;

namespace UnitTest
{
    [TestClass]
    public class UnitTestAccountRepo
    {
        BankAccount _accountInfo;
        Customer _custInfo = new Customer()
        {
            custID = "1234567890123",
            custName = "ธนชาติ",
            custSurname = "ช้างเจริญ",
        };

        void initDB()
        {
            NHibernateHelper.DatabaseFile = @"D:\VisualStudioProject\TestBank\TestBank\App_Data\MySQL.xml.cfg";
        }

        private AppLogic GetAppLogic(ISession session)
        {
            return new AppLogic(new CustomerRepository(session), new AccountRepository(session));
        }

        [TestMethod]
        public void TestCreateAccount()
        {
            initDB();
            List<BankAccount> actual = null;
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    GetAppLogic(session).CreateAccount(_custInfo);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                finally
                {
                    session.Close();
                }
            }

            using (var session = NHibernateHelper.OpenSession())
            {
                try
                {
                    actual = GetAppLogic(session).GetAccountByCustID(_custInfo.custID);
                }
                finally
                {
                    session.Close();
                }
            }
            Assert.IsTrue(actual.Count > 0);
        }

        //[TestMethod]
        //public void TestDeleteAccountByCustID()
        //{
        //    initDB();
        //    List<BankAccount> actual = null;
        //    using (var session = NHibernateHelper.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        try
        //        {
        //            GetAppLogic(session).DeleteAccountByCustID(_custInfo.custID);
        //            transaction.Commit();
        //        }
        //        catch
        //        {
        //            transaction.Rollback();
        //        }
        //        finally
        //        {
        //            session.Close();
        //        }
        //    }

        //    using (var session = NHibernateHelper.OpenSession())
        //    {
        //        try
        //        {
        //            actual = GetAppLogic(session).GetAccountByCustID(_custInfo.custID);
        //        }
        //        finally
        //        {
        //            session.Close();
        //        }
        //    }

        //    Assert.IsTrue(actual.Count == 0);
        //}

        [TestMethod]
        public void TestGenerateIBAN()
        {
            initDB();
            String actual = null;
            using (var session = NHibernateHelper.OpenSession())
            //using (var transaction = session.BeginTransaction())
            {
                try
                {
                    actual = GetAppLogic(session).GenerateIBAN();
                    //transaction.Commit();
                }
                catch(Exception ex)
                {
                    //transaction.Rollback();
                }
                finally
                {
                    session.Close();
                }
            }

            Console.WriteLine(actual);
            Assert.IsNotNull(actual);
        }
    }
}
