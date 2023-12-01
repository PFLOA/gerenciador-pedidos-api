using System.Collections.Generic;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class CondicoesPagamento : EntityBase
    {
        public int? QuantidadeParcelas { get; set; }
        public short? ContaDebitarId { get; set; }
        public short? PlanoContasId { get; set; }
        public short? MeioPagamentoId { get; set; }
        public short? BandeiraOperadoraId { get; set; }
        public decimal? TaxaAdministrativa { get; set; }

        public string Descricao { get; set; }
        public string CnpjCredenciadoraCartao { get; set; }
        public string CodCredenciadora { get; set; }

        public bool? IsPrazo { get; set; }
        public bool? IsDataComercial { get; set; }
        public bool? IsGeraMovimentacaoFinanceira { get; set; }

        [IgnoreDataMember]
        public virtual Cliente Cliente { get; set; }

        [IgnoreDataMember]
        public virtual Conta ContaDebitar { get; set; }


        [IgnoreDataMember]
        public virtual MeioPagamento MeioPagamento { get; set; }


        [IgnoreDataMember]
        public virtual BandeiraOperadora BandeiraOperadora { get; set; }


        [IgnoreDataMember]
        public virtual PlanoContas PlanoContas { get; set; }

        [IgnoreDataMember]
        public virtual IList<ContasReceber> ContasReceber { get; set; }


        [IgnoreDataMember]
        public virtual List<Parcelas> Parcelas { get; set; }
    }
}
