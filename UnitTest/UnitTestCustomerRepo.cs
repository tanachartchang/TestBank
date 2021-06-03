using AppBL;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NHibernate;
using Repository.Implementation;
using TestBank;

namespace UnitTest
{
    [TestClass]
    public class UnitTestCustomerRepo
    {
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
            return new AppLogic(new CustomerRepository(session), new AccountRepository(session), new TransactionRepository(session), new ConfigRepository(session));
        }

        [TestMethod]
        public void TestDeleteCustomer()
        {
            initDB();
            Customer actual = _custInfo;
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    GetAppLogic(session).DeleteCustomer(_custInfo);
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
                    actual = GetAppLogic(session).GetCustomerByID(_custInfo.custID);
                }
                finally
                {
                    session.Close();
                }
            }

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestCreateCustomer()
        {
            initDB();
            Customer actual = null;

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    GetAppLogic(session).CreateCustomer(_custInfo);
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
                    actual = GetAppLogic(session).GetCustomerByID(_custInfo.custID);
                }
                finally
                {
                    session.Close();
                }
            }

            Assert.IsNotNull(actual);
        }
    }
}
