using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace VPRCracha.Domain.Model.Repository.SQServer.Mappings
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            this.Id(us => us.ID).GeneratedBy.Identity();
            this.Map(us => us.Login);
            this.Map(us => us.Nome);
            this.Map(us => us.Senha);
        }
    }
}
