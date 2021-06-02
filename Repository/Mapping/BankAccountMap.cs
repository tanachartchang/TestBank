using Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mapping
{
    public class BankAccountMap : ClassMap<BankAccount>
    {
        public BankAccountMap()
        {
            Table("bank_account");
            Id(x => x.accountNo, "account_no");
            Map(x => x.custID, "cust_id");
            Map(x => x.balance, "balance");
        }
    }
}
