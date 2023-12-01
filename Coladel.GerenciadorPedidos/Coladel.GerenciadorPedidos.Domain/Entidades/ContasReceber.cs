using A4S.Core.Extensions;
using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace A4S.ERP.Domain.Entidades
{
    public class ContasReceber : Entity
    {
        public short ClienteId { get; set; }
        public short CondicaoPagamentoId { get; set; }

        public string Duplicata { get; set; }

        public decimal ValorLiquido { get; set; }
        public decimal ValorPagamento { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAbatimento { get; set; }

        public int Juros { get; set; }
        public int Multa { get; set; }

        public StatusContas Status { get; set; } = StatusContas.ABERTO;

        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }

        [NotMapped]
        public decimal JurosDia
        {
            get { return Convert.ToDecimal(Juros) / 30; }
        }

        public virtual Cliente Cliente { get; set; }
        public virtual CondicoesPagamento CondicoesPagamento { get; set; }
        public virtual Remessas Remessas { get; set; }

        public ContasReceber() { }
        public ContasReceber(CriarContasReceberBody requestBody) => requestBody.MappingProperties(this);

    }
}
