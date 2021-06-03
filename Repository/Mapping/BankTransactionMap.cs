using Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mapping
{
    public class BankTransactionMap : ClassMap<BankTransaction>
    {
        public BankTransactionMap()
        {
            Table("transaction");
            Id(x => x.id, "id").GeneratedBy.Increment();
            Map(x => x.trans_type, "trans_type");
            Map(x => x.from_acc, "from_acc");
            Map(x => x.to_acc, "to_acc");
            Map(x => x.value, "value");
            Map(x => x.fee_rate, "fee_rate");
            Map(x => x.fee_amount, "fee_amount");
            Map(x => x.total, "total");
        }
    }
}
