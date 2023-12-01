using A4S.ERP.Domain.Entidades;
using System;

namespace A4S.ERP.Domain.Body
{
    public class CriarContasReceberBody
    {
        public short ClienteId { get; set; }
        public short CondicaoPagamentoId { get; set; }

        public string Duplicata { get; set; }

        public decimal ValorLiquido { get; set; }
        public decimal ValorBruto { get; set; }

        public int Juros { get; set; }
        public int Multa { get; set; }

        public DateTime DataVencimento { get; set; }

        public virtual ContasReceber ToModel() => new ContasReceber(this);
    }
}
