using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPRCracha.Domain.Model
{
    public class Regiao : VPRCracha.Domain.Model.Entidades.Entidade<Regiao>
    {
        public virtual string Nome { get; set; }
        public virtual Usuario ResponsavelRegiao { get; set; }
    }
}
