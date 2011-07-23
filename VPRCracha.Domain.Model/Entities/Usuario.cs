using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPRCracha.Domain.Model
{
    public class Usuario : VPRCracha.Domain.Model.Entidades.Entidade<Usuario>
    {
        public Usuario(){}
        public Usuario(int id):base(id){}
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Nome { get; set; }
    }
}
