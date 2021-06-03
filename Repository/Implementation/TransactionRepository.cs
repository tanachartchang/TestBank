using Domain;
using NHibernate;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class TransactionRepository : ITransactionRepository
    {
        private ISession _session;

        public TransactionRepository(ISession session)
        {
            _session = session;
        }

        public void CreateTransaction(BankTransaction trans)
        {
            _session.Save(trans);
        }
    }
}
