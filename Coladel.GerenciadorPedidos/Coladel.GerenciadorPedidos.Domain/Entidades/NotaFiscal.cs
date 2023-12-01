using System;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Entidades
{
    public class NotaFiscal : Entity
    {
        public short ClienteId { get; set; }
        public short TransporteNfId { get; set; }
        public short TributosNfId { get; set; }
        public short CobrancaId { get; set; }

        public decimal Total { get; set; }
        public decimal TotalTributos { get; set; }

        public string InformacoesComplementares { get; set; }
        public string Chave { get; set; }

        public DateTime DataEmissao { get; set; }
        public DateTime DataSaida { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TransporteNf TransporteNf { get; set; }
        public virtual CobrancaNf Cobranca { get; set; }

        public virtual IEnumerable<ItensNotaFiscal> ItensNotaFiscal { get; set; }
        public virtual TributosNf TributosNf { get; set; }
    }
}
