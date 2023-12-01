using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class SubGrupoProduto : EntityBase
    {
        public string Descricao { get; set; }
        public short GrupoId { get; set; }
        public string Ncm { get; set; }

        [IgnoreDataMember]
        public virtual List<Produto> Produtos { get; set; }

        [IgnoreDataMember]
        public virtual GrupoProduto Grupo { get; set; }
    }
}
