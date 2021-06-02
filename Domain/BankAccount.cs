using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BankAccount
    {
        public virtual String accountNo { get; set; }
        public virtual String custID { get; set; }
        public virtual Double? balance { get; set; }
    }
}
