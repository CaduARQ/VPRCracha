using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;

namespace VPRCracha.Domain.Model.Repository.SQServer.Impl
{
    public class RegiaoRepository : Repository<Regiao>, IRegiaoRepository
    {
        public Regiao ListarRegiaoComCrachasAssociados(int id)
        {
            return base.Pesquisar(id);
        }
    }
}
