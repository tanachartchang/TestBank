using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BankTransaction
    {
        public virtual Int64 id { get; set; }
        public virtual String trans_type { get; set; }
        public virtual String from_acc { get; set; }
        public virtual String to_acc { get; set; }
        public virtual Double? value { get; set; }
        public virtual Double? fee_rate { get; set; }
        public virtual Double? fee_amount { get; set; }
        public virtual Double? total { get; set; }
    }
}
