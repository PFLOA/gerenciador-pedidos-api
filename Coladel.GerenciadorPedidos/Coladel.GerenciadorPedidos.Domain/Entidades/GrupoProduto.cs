using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class GrupoProduto : EntityBase
    {
        public string Descricao { get; set; }

        [IgnoreDataMember]
        public virtual List<Produto> Produtos { get; set; }

        [IgnoreDataMember]
        public virtual List<SubGrupoProduto> SubGrupos { get; set; }
    }
}
