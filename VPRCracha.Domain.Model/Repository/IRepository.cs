using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPRCracha.Domain.Model.Repository
{
    public interface IRepository<TEntity> where TEntity: class
    {
        void Salvar(TEntity entity);
        void Atualizar(TEntity entity);
        IEnumerable<TEntity> ListaTodos();
        TEntity Pesquisar(int id);
    }
}
