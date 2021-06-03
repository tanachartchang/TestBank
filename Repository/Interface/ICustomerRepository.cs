using Domain;
using System;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface ICustomerRepository
    {
        Customer CreateCust(Customer custInfo);
        void DeleteCust(Customer custInfo);
        List<Customer> GetAllCust();
        Customer GetCustByID(String custID);
    }
}