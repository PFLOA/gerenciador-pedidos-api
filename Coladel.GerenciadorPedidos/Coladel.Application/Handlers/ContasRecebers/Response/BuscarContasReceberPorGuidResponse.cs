using A4S.Core.Extensions;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Response
{
    public class BuscarContasReceberPorGuidResponse
    {
        public short Id { get; set; }

        public string Duplicata { get; set; }

        public decimal ValorLiquido { get; set; }
        public decimal ValorPagamento { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAbatimento { get; set; }

        public int Juros { get; set; }
        public int Multa { get; set; }

        public StatusContas Status { get; set; }

        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }

        public Cliente Cliente { get; set; }
        public CondicoesPagamento CondicoesPagamento { get; set; }
        public Remessas Remessas { get; set; }

        public BuscarContasReceberPorGuidResponse(ContasReceber contasReceber)
        {
            contasReceber.MappingProperties(this);
        }
    }
}
