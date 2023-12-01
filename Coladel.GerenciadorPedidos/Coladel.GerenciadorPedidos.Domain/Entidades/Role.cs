using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Role : EntityBase
    {
        public string Descricao { get; set; }

        [IgnoreDataMember]
        public virtual List<Usuario> Usuarios { get; set; }
    }
}
