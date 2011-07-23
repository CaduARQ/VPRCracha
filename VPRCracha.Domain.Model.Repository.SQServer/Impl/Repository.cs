using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using System.Configuration;

namespace VPRCracha.Domain.Model.Repository.SQServer.Impl
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class 
    {
        protected ISessionFactory __sessionFactory;
        protected ISession __session;

        public Repository()
        {
            this.__sessionFactory = FluentSessionFactory.CreateFactory(ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
            this.__session = this.__sessionFactory.OpenSession();
        }

        public void Salvar(TEntity entity)
        {
            using (var transaction = this.__session.BeginTransaction())
            {
                this.__session.Save(entity);
                transaction.Commit();
            }
        }

        public void Atualizar(TEntity entity)
        {
            using (var transaction = this.__session.BeginTransaction())
            {
                this.__session.Save(entity);
                transaction.Commit();
            }
        }

        public IEnumerable<TEntity> ListaTodos()
        {
            var criterio = this.__session.CreateCriteria<TEntity>();
            return criterio.List<TEntity>();
        }

        public TEntity Pesquisar(int id)
        {
            return this.__session.Get<TEntity>(id);
        }
    }
}
