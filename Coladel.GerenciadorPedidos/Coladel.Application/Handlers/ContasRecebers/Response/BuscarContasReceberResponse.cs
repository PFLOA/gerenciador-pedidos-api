using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using System;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Response
{
    public class BuscarContasReceberResponse
    {
        public Guid Guid { get; set; }
        public string Duplicata { get; set; }
        public string RazaoSocial { get; set; }
        public string CondicoesPagamento { get; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorBruto { get; set; }
        public DateTime DataVencimento { get; set; }
        public StatusContas Status { get; set; }

        public BuscarContasReceberResponse(ContasReceber c)
        {
            Guid = c.Guid;
            Duplicata = c.Duplicata;
            RazaoSocial = c.Cliente.RazaoSocial;
            CondicoesPagamento = c.CondicoesPagamento.Descricao;
            ValorBruto = c.ValorBruto;
            ValorLiquido = c.ValorLiquido;
            DataVencimento = c.DataVencimento;
            Status = c.Status;
        }
    }
}
