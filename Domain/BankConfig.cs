using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BankConfig
    {
        public virtual DateTime effective_date { get; set; }
        public virtual Double? fee_deposite { get; set; }
        public virtual Double? fee_withdraw { get; set; }
        public virtual Double? fee_transfer { get; set; }
    }
}
