using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using VPRCracha.Domain.Model.Repository.SQServer.Mappings;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;

namespace VPRCracha.Domain.Model.Repository.SQServer
{
    public class FluentSessionFactory
    {
        public static ISessionFactory CreateFactory(string connectionString)
        {
            return Fluently.Configure()
              .Database(MsSqlConfiguration.MsSql2005.ConnectionString(connectionString))
              .Mappings(
                m => m.FluentMappings
                    .AddFromAssemblyOf<Regiao>()
                    .AddFromAssemblyOf<RegiaoMap>()
              )
              .ExposeConfiguration(BuildSchema)
              .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config)
        {
            //SchemaExport schema = new SchemaExport(config);
            //schema.Drop(false, true);
            //schema.Create(false, true);

            SchemaUpdate schemaUpdate = new SchemaUpdate(config);
            schemaUpdate.Execute(true, true);
        }

    }
}
