using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace VPRCracha.Domain.Model.Repository.SQServer.Mappings
{
    public class RegiaoMap : ClassMap<Regiao>
    {
        public RegiaoMap()
        {
            this.Id(rg => rg.ID);
            this.Map(rg => rg.Nome);
            this.References(rg => rg.ResponsavelRegiao).Cascade.SaveUpdate();
        }
    }
}
