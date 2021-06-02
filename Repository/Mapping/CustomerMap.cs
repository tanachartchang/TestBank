using Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mapping
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("customer");
            Id(x => x.custID, "cust_id");
            Map(x => x.custName, "cust_name");
            Map(x => x.custSurname, "cust_surname");
        }
    }
}
