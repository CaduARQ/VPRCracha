using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace VPRCracha.Domain.Model.Repository.SQServer.Mappings
{
    public class CrachaMap : ClassMap<Cracha>
    {
        public CrachaMap()
        {
            this.Id(cr => cr.ID).GeneratedBy.Identity();
            this.Map(cr => cr.NumeracaoCracha);
            this.References(cr => cr.RegiaoCracha).Cascade.None();
        }
    }
}
