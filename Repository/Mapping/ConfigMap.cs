using Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mapping
{
    public class ConfigMap : ClassMap<BankConfig>
    {
        public ConfigMap()
        {
            Table("bank_config");
            Id(x => x.effective_date, "effective_date");
            Map(x => x.fee_deposite, "fee_deposite");
            Map(x => x.fee_withdraw, "fee_withdraw");
            Map(x => x.fee_transfer, "fee_transfer");
        }
    }
}
