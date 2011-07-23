using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPRCracha.Domain.Model
{
    public class Cracha : VPRCracha.Domain.Model.Entidades.Entidade<Cracha>
    {
        public virtual string NumeracaoCracha { get; set; }

        public virtual Regiao RegiaoCracha { get; set; }
    }
}
