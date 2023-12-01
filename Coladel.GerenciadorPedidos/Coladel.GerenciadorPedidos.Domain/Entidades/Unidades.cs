using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Unidades : EntityBase
    {
        public string Unidade { get; set; }
        public string Descricao { get; set; }

        
        [IgnoreDataMember]
        public virtual List<InformacoesFiscais> InformacoesFiscais { get; set; }


        [IgnoreDataMember]
        public virtual List<Embalagem> Embalagens { get; set; }
    }
}
