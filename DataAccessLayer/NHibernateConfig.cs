using DataAccessLayer.Convensions;
using DataAccessLayer.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class NHibernateConfig
    {
        private const string ConnectionString =
            @"Data Source=EN60379; Initial Catalog=ProiectGraduates; Integrated Security=true";

        private static ISession _session;
        private static ISessionFactory _sessionFactory;

        public static ISession Session
        {
            get { return _session ?? (_session = SessionFactory.OpenSession()); }
        }

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitSessionFactory();
                return _sessionFactory;
            }
        }

        static void InitSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(ConnectionString))
                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<Article>()
                    .Conventions.Add(new ForeignKeyNameConvention(), new CustomManyToManyTableNameConvention())
                )
                .BuildSessionFactory();
        }
    }
}
