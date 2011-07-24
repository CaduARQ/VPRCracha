using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace VPRCracha.Tests.Common
{
    public class TestSessionFactorySQLLite
    {
        protected static ISessionFactory sessionFactory;

        protected static Configuration configuration;

        public static void OneTimeInitalize(params Assembly[] assemblies)   
        {
            if (sessionFactory != null) return;

            Dictionary<string, string> properties = new Dictionary<string, string>();

            properties.Add("connection.driver_class", "NHibernate.Driver.SQLite20Driver");

            properties.Add("dialect", "NHibernate.Dialect.SQLiteDialect");

            properties.Add("connection.provider", "NHibernate.Connection.DriverConnectionProvider");

            properties.Add("query.substitutions", "true=1;false=0");

            properties.Add("connection.connection_string", "Data Source=MyTestDb.db;Version=3;New=True;");

            configuration = new Configuration();

            configuration.SetProperties(properties);

            foreach (Assembly assembly in assemblies)
            {
                configuration = configuration.AddAssembly(assembly);
            }

            sessionFactory = configuration.BuildSessionFactory();

        }  

 

        public ISession CreateSession()
        {

          ISession openSession = sessionFactory.OpenSession();

          IDbConnection connection = openSession.Connection;

          new SchemaExport(configuration).Execute(true, true, true);

          return openSession;

        }

    }
}
