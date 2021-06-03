﻿using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using Repository.Mapping;

namespace TestBank
{
    /// <summary>
    /// NHibernate Helper
    /// </summary>
    /// <remarks>
    /// Because the SessionFactory creation is lazy-loaded, you technically never need to bootstrap NHibernate
    /// and instead can just call OpenSession() as it will do it for you the first time you make the call.
    /// </remarks>
    public static class NHibernateHelper
    {
        #region Private Fields

        private static ISessionFactory _sessionFactory;

        #endregion Private Fields

        #region Public Properties

        public static string DatabaseFile = "";
        public static bool IsCreateDatabsae = false;
        /// <summary>
        /// Creates <c>ISession</c>s.
        /// </summary>
        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        /// <summary>
        /// Allows the application to specify properties and mapping documents to be used when creating a <see cref="T:NHibernate.ISessionFactory"/>.
        /// </summary>
        public static FluentConfiguration Configuration { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Open a new NHibenate Session
        /// </summary>
        /// <returns>A new ISession</returns>
        public static ISession OpenSession()
        {
            var session = SessionFactory.OpenSession();

            return session;
        }

        /// <summary>
        /// Open a new stateless NHibernate Session
        /// </summary>
        /// <returns>Stateless NHibernate Session</returns>
        public static IStatelessSession OpenStatelessSession()
        {
            var session = SessionFactory.OpenStatelessSession();

            return session;
        }



        #endregion Public Methods

        #region Private Methods

        private static ISessionFactory CreateSessionFactory()
        {
            if (Configuration == null)
            {

                Configuration = Fluently.Configure(new Configuration().Configure(DatabaseFile));
                Configuration.Mappings(map => map.FluentMappings.AddFromAssemblyOf<BankAccountMap>()
                                                                .AddFromAssemblyOf<CustomerMap>()
                                                                .AddFromAssemblyOf<BankTransactionMap>()
                                                                .AddFromAssemblyOf<ConfigMap>());
                Configuration.ExposeConfiguration(x =>
                {
                    x.SetInterceptor(new Inceptor());
                });

            }

            var sessionFactory = Configuration.BuildSessionFactory();

            return sessionFactory;
        }

        #endregion Private Methods
    }

}