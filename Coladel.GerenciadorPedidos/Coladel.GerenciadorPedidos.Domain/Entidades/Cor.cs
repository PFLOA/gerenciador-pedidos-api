using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Cor : EntityBase
    {
        public string Descricao { get; set; }

        [IgnoreDataMember]
        public virtual List<Produto> Produtos { get; set; }
    }
}
