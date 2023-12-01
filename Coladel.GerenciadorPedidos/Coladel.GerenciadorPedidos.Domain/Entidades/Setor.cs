using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Setor : EntityBase
    {
        public string Descricao { get; set; }

        [IgnoreDataMember]
        public List<Usuario> Usuarios { get; set; }
    }
}
