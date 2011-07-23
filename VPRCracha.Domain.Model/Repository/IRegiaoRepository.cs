using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPRCracha.Domain.Model.Repository
{
    public interface IRegiaoRepository : IRepository<Regiao>
    {
        Regiao ListarRegiaoComCrachasAssociados(int id);
    }
}
