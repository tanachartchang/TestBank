using Domain;
using NHibernate;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{
    public class ConfigRepository : IConfigRepository
    {
        private ISession _session;

        public ConfigRepository(ISession session)
        {
            _session = session;
        }

        public BankConfig GetConfig()
        {
            var query = from u in _session.QueryOver<BankConfig>()
                        where u.effective_date <= DateTime.Now
                        select u;
            return query.List<BankConfig>().OrderByDescending(x => x.effective_date).FirstOrDefault();
        }
    }
}
