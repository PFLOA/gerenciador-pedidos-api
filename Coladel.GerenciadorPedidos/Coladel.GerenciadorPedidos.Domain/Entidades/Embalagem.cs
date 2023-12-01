using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Embalagem : EntityBase
    {
        [IgnoreDataMember]
        public short UnidadesId { get; set; }

        public string Descricao { get; set; }
        public string Dimensoes { get; set; }

        public virtual Unidades Unidades { get; set; }


        [IgnoreDataMember]
        public virtual List<Produto> Produtos { get; set; }
    }
}
