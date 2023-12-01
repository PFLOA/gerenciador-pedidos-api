using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class Remessas : EntityBase
    {
        public short ClienteId { get; set; }
        public short ContasReceberId { get; set; }

        public string HtmlBoleto { get; set; }
        public string ArquivoRemessa { get; set; }

        [IgnoreDataMember]
        public virtual Cliente Cliente { get; set; }

        [IgnoreDataMember]
        public virtual ContasReceber ContasReceber { get; set; }
    }
}
