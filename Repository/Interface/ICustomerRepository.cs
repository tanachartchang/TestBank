using Domain;
using System;

namespace Repository.Interface
{
    public interface ICustomerRepository
    {
        Customer CreateCust(Customer custInfo);
        void DeleteCust(Customer custInfo);
        Customer GetCustByID(String custID);
    }
}