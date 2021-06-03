using Domain;
using NHibernate;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ISession _session;

        public CustomerRepository(ISession session)
        {
            _session = session;
        }
        public Customer GetCustByID(String custID)
        {
            var query = from u in _session.QueryOver<Customer>()
                        where u.custID == custID
                        select u;
            return query.List<Customer>().FirstOrDefault();
        }
        public List<Customer> GetAllCust()
        {
            var query = from u in _session.QueryOver<Customer>()
                        where u.custID != null
                        select u;
            return query.List<Customer>().ToList();
        }

        public Customer CreateCust(Customer custInfo)
        {
            _session.SaveOrUpdate(custInfo);
            return custInfo;
        }

        public void DeleteCust(Customer custInfo)
        {
            _session.Delete(custInfo);
        }
    }
}
